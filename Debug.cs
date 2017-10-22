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
    public partial class Debug : Form
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void Debug_Load(object sender, EventArgs e)
        {

        }

        private void ArtifactsBtn_Click(object sender, EventArgs e)
        {
            CardCollection collection = CardCollection.LoadFromSources();
            List<Expansion> allExp = new List<Expansion>();

            foreach(Expansion exp in Enum.GetValues(typeof(Expansion)))
            {
                allExp.Add(exp);
            }

            DataTable table = new DataTable("cardsTable");
            table.Columns.Add(new DataColumn("Name"));
            table.Columns.Add(new DataColumn("Type"));
            table.Columns.Add(new DataColumn("Traits"));
            table.Columns.Add(new DataColumn("Cost"));
            table.Columns.Add(new DataColumn("Expansion"));
            table.Columns.Add(new DataColumn("Num. in Deck"));

            foreach (InvestigatorCard card in collection.InDeck)
            {
                DataRow row = table.NewRow();
                row.SetField("Name", card.Name);
                row.SetField("Type", card.CardType.ToString());
                row.SetField("Traits", string.Join(", ", card.Traits));
                row.SetField("Cost", (card.CardType == InvestigatorCardType.Asset) ? ((AssetCard)card).Cost.ToString() : "-");
                row.SetField("Expansion", card.Expansion.ToString());
                row.SetField("Num. in Deck", collection.GetQuantityInCollectionDeck(card, allExp));
                table.Rows.Add(row);
            }

            CardDataGrid.DataSource = table;
            CardDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            string filename = "E:\\workAndCollege\\eldritch\\EHHelper\\src\\master.cards";
            collection.Save(filename);
        }

        private void LoadMasterBtn_Click(object sender, EventArgs e)
        {
            string filename = "master.cards";
            CardCollection collection = CardCollection.Load(filename);
            List<Expansion> allExp = new List<Expansion>();

            foreach (Expansion exp in Enum.GetValues(typeof(Expansion)))
            {
                allExp.Add(exp);
            }

            DataTable table = new DataTable("cardsTable");
            table.Columns.Add(new DataColumn("Name"));
            table.Columns.Add(new DataColumn("Type"));
            table.Columns.Add(new DataColumn("Traits"));
            table.Columns.Add(new DataColumn("Cost"));
            table.Columns.Add(new DataColumn("Expansion"));
            table.Columns.Add(new DataColumn("Num. in Deck"));

            foreach (InvestigatorCard card in collection.InDeck)
            {
                DataRow row = table.NewRow();
                row.SetField("Name", card.Name);
                row.SetField("Type", card.CardType.ToString());
                row.SetField("Traits", string.Join(", ", card.Traits));
                row.SetField("Cost", (card.CardType == InvestigatorCardType.Asset) ? ((AssetCard)card).Cost.ToString() : "-");
                row.SetField("Expansion", card.Expansion.ToString());
                row.SetField("Num. in Deck", collection.GetQuantityInCollectionDeck(card, allExp));
                table.Rows.Add(row);
            }

            CardDataGrid.DataSource = table;
            CardDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        //private void ArtifactsBtn_Click(object sender, EventArgs e)
        //{
        //    LoadAndDisplay(InvestigatorCardType.Artifact);
        //}

        private void AssetsBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplay(InvestigatorCardType.Asset);
        }

        private void SpellsBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplay(InvestigatorCardType.Spell);
        }

        private void ConditionsBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplay(InvestigatorCardType.Condition);
        }

        private void UniqueAssetsBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplay(InvestigatorCardType.UniqueAsset);
        }

        /// <summary>
        /// Loads and displays all cards of a given type from file / stored manual input.
        /// </summary>
        /// <param name="type"></param>
        private void LoadAndDisplay(InvestigatorCardType type)
        {
            try
            {
                IEnumerable<InvestigatorCard> cards;

                switch(type)
                {
                    case InvestigatorCardType.Artifact:
                        cards = HTMLReader.GetArtifacts();
                        break;
                    case InvestigatorCardType.Asset:
                        cards = HTMLReader.GetAssets();
                        break;
                    case InvestigatorCardType.Spell:
                        cards = HTMLReader.GetSpells();
                        break;
                    case InvestigatorCardType.Condition:
                        cards = HTMLReader.GetConditions();
                        break;
                    case InvestigatorCardType.UniqueAsset:
                        cards = UniqueAssetsManual.GetAllUniqueAssets();
                        break;
                    default:
                        throw new Exception("Type not handled: " + type);
                }

                MessageBox.Show(string.Format("{0} cards loaded.", cards.Count()));

                DataTable table = new DataTable("cardsTable");
                table.Columns.Add(new DataColumn("Name"));
                table.Columns.Add(new DataColumn("Traits"));
                table.Columns.Add(new DataColumn("Expansion"));

                foreach (InvestigatorCard card in cards)
                {
                    DataRow row = table.NewRow();
                    row.SetField("Name", card.Name);
                    row.SetField("Traits", string.Join(", ", card.Traits));
                    row.SetField("Expansion", card.Expansion.ToString());
                    table.Rows.Add(row);
                }

                CardDataGrid.DataSource = table;
                CardDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n---\n" + ex.StackTrace);
            }
        }
    }
}
