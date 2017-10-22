using EldritchHorrorHelper.Data;
using EldritchHorrorHelper.InvestigatorCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EldritchHorrorHelper
{
    public partial class Main : Form
    {
        private CardCollection cards;
        private List<InvestigatorCard> blacklist;
        private InvestigatorCard lastCard;
        private BindingList<InvestigatorCard> discardDataGridSource;

        public Main()
        {
            InitializeComponent();

            cards = OpeningWindow.COLLECTION;
            blacklist = new List<InvestigatorCard>();
            lastCard = null;
            discardDataGridSource = new BindingList<InvestigatorCard>();

            DiscardsDataGrid.DataSource = discardDataGridSource;

            foreach (InvestigatorCard card in cards.InDeck)
            {
                if (cards.Discards[card] > 0)
                {
                    discardDataGridSource.Add(card);
                }
            }

            MessageBox.Show("Active expansions:\n" + string.Join("\n", cards.ExpansionsInUse));

            foreach (InvestigatorCardType type in Enum.GetValues(typeof(InvestigatorCardType)))
            {
                CardTypeBox.Items.Add(type);
            }
            CardTypeBox.SelectedIndex = 0;

            Tooltip.SetToolTip(TraitsTextBox,
                "Enter tags (the block-capital bold italicised text like ITEM or RITUAL) here.\n" +
                "Add multiple with spaces between to only draw a card with all of those tags (EG: 'ITEM MAGICAL RELIC').\n" +
                "Use parentheses to select any of the contained tags (EG: '(ITEM TRINKET) TOME' to get either an ITEM TOME or TRINKET TOME.)");
            Tooltip.SetToolTip(CostTextBox,
                "Only applies to assets. Range is 1-4. Anything outside this range or not a number will be ignored.");
            Tooltip.SetToolTip(RedrawCardBtn,
                "Discards/shuffles back the current card as appropriate for it's type and draws a new one that will not have the same name as this or any other " +
                "cards drawn since the last draw.");
            Tooltip.SetToolTip(KeepCardBtn,
                "When this is clicked, the last card drawn will be considered kept and will be removed from the pool, preventing it from appearing in the future.\n" +
                "This can be undone in the 'Removed' tab.");
        }

        private void DrawCardBtn_Click(object sender, EventArgs e)
        {
            blacklist = new List<InvestigatorCard>();

            int? cost;

            if (int.TryParse(CostTextBox.Text, out int i))
            {
                if (i > 4 || i <= 0)
                {
                    cost = null;
                }
                else
                {
                    cost = i;
                }
            }
            else
            {
                cost = null;
            }
            
            InvestigatorCard card = Draw((InvestigatorCardType)CardTypeBox.SelectedIndex, TraitsTextBox.Text, cost, new List<InvestigatorCard>());

            if (card != null)
            {
                blacklist.Add(card);
                DisplayDrawnCard(card);
            }
            else
            {
                DisplayNoDrawMessage();
            }

            lastCard = card;
        }

        private void RedrawCardBtn_Click(object sender, EventArgs e)
        {
            int? cost;

            if (int.TryParse(CostTextBox.Text, out int i))
            {
                if (i > 4 || i <= 0)
                {
                    cost = null;
                }
                else
                {
                    cost = i;
                }
            }
            else
            {
                cost = null;
            }

            InvestigatorCard card = Draw((InvestigatorCardType)CardTypeBox.SelectedIndex, TraitsTextBox.Text, cost, blacklist);

            if (card != null)
            {
                blacklist.Add(card);
                DisplayDrawnCard(card);
            }
            else
            {
                DisplayNoDrawMessage();
            }

            lastCard = card;
        }

        private void ShuffleDiscardsBtn_Click(object sender, EventArgs e)
        {
            cards.ClearDiscard();
            discardDataGridSource.Clear();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            OpeningWindow.INSTANCE.Close();
        }

        /// <summary>
        /// Draws a card.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="traitString"></param>
        /// <param name="cost"></param>
        /// <param name="blacklist">Will not draw cards from this list.</param>
        /// <returns>Null if none available.</returns>
        private InvestigatorCard Draw(InvestigatorCardType type, string traitString, int? cost, List<InvestigatorCard> blacklist)
        {
            IEnumerable<InvestigatorCard> potentialDraws = cards.InDeck.Except(blacklist);
            Dictionary<int, InvestigatorCard> pool = new Dictionary<int, InvestigatorCard>();
            int poolIndex = 0;
            TraitPredicate tp = new TraitPredicate(traitString);

            foreach (InvestigatorCard card in potentialDraws)
            {
                bool checkForCost = (type == InvestigatorCardType.Asset && cost.HasValue);

                if (card.CardType == type && tp.IsValid(card) &&
                    (!checkForCost || ((AssetCard)card).Cost == cost.Value))
                {
                    for (int i = 0; i < cards.GetQuantityInCollectionDeck(card); i++)
                    {
                        pool.Add(poolIndex, card);
                        poolIndex++;
                    }
                }
            }

            if (pool.Count > 0)
            {
                Random rand = new Random();
                int i = rand.Next(0, pool.Count);
                return pool[i];
            }
            else
            {
                //No possible cards
                return null;
            }
        }

        /// <summary>
        /// Displays the message for when no card can be drawn.
        /// </summary>
        private void DisplayNoDrawMessage()
        {
            CardDrawLabel.Text = "No card could be drawn - nothing matches parameters.";
        }

        /// <summary>
        /// Displays the drawn card.
        /// </summary>
        /// <param name="card"></param>
        private void DisplayDrawnCard(InvestigatorCard card)
        {
            string msg = string.Format("Name: {0}\nType: {1}\nTraits: {2}",
                card.Name, card.CardType, string.Join(", ", card.Traits));

            if (card is AssetCard)
            {
                msg += string.Format("\nCost: {0}", ((AssetCard)card).Cost);
            }

            CardDrawLabel.Text = msg;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.ShowDialog();
            cards.Save(savefile.FileName);
            CardDrawLabel.Text = "Saved successfully.";
        }

        private void KeepCardBtn_Click(object sender, EventArgs e)
        {
            if (lastCard != null)
            {
                //if (lastCard.CardType == InvestigatorCardType.Artifact || lastCard.CardType == InvestigatorCardType.Asset ||
                //    (lastCard.CardType == InvestigatorCardType.UniqueAsset && lastCard.GetQuantity(ExpansionExtensions.GetAllExpansions()) == 1))
                //{
                    cards.Discards[lastCard] += 1;
                    blacklist = new List<InvestigatorCard>();
                    CardDrawLabel.Text = "Card removed from pool.";
                    discardDataGridSource.Add(lastCard);
                    lastCard = null;
                //}
                //else
                //{
                //    CardDrawLabel.Text = "This type of card cannot be removed from the pool.";
                //}
            }
            else
            {
                CardDrawLabel.Text = "No card selected.";
            }
        }

        private void ShuffleSelectionBtn_Click(object sender, EventArgs e)
        {
            if (DiscardsDataGrid.SelectedRows.Count > 0)
            {
                List<string> names = new List<string>();

                foreach (DataGridViewRow row in DiscardsDataGrid.SelectedRows)
                {
                    names.Add(row.Cells["Name"].Value.ToString());
                }

                cards.ClearDiscardByName(names);

                List<InvestigatorCard> displayedDiscards = new List<InvestigatorCard>(discardDataGridSource);

                foreach (InvestigatorCard card in displayedDiscards)
                {
                    if (names.Contains(card.Name))
                    {
                        discardDataGridSource.Remove(card);
                    }
                }
            }
        }
    }
}
