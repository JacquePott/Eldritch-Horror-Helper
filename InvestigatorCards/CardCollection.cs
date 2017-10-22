using EldritchHorrorHelper.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.InvestigatorCards
{
    /// <summary>
    /// A collection of cards to use for helping run a game.
    /// </summary>
    [Serializable]
    public class CardCollection
    {
        public List<InvestigatorCard> InDeck { get; private set; }
        public Dictionary<InvestigatorCard, int> Discards { get; private set; }
        public List<Expansion> ExpansionsInUse { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        private CardCollection()
        {
            InDeck = new List<InvestigatorCard>();
            Discards = new Dictionary<InvestigatorCard, int>();
            ExpansionsInUse = new List<Expansion>() { Expansion.Core };
        }

        /// <summary>
        /// Gets the quantity of the given card in the collection's deck.
        /// </summary>
        /// <param name="card"></param>
        /// <param name="expSet"></param>
        /// <returns></returns>
        public int GetQuantityInCollectionDeck(InvestigatorCard card, IEnumerable<Expansion> expSet = null)
        {
            if (expSet == null)
            {
                expSet = ExpansionsInUse;
            }

            int baseQuantity = card.GetQuantity(expSet);
            return baseQuantity - Discards[card];
        }

        /// <summary>
        /// Shuffles discarded cards of the given type back into the deck.
        /// </summary>
        /// <param name="type"></param>
        public void ClearDiscard(InvestigatorCardType type)
        {
            foreach (InvestigatorCard card in InDeck)
            {
                if (card.CardType.Equals(type))
                {
                    Discards[card] = 0;
                }
            }
        }

        /// <summary>
        /// Shuffles discarded cards back into the deck.
        /// </summary>
        public void ClearDiscard()
        {
            foreach (InvestigatorCard card in InDeck)
            {
                Discards[card] = 0;
            }
        }

        /// <summary>
        /// Shuffles all cards with the given names back into the decks.
        /// </summary>
        /// <param name="cardNames"></param>
        public void ClearDiscardByName(List<string> cardNames)
        {
            foreach (InvestigatorCard card in InDeck)
            {
                if (cardNames.Contains(card.Name))
                {
                    Discards[card] = 0;
                }
            }
        }

        /// <summary>
        /// Discards all assets of a given cost.
        /// </summary>
        /// <param name="cost"></param>
        public void DiscardByCost(int cost)
        {
            foreach (AssetCard asset in InDeck)
            {
                if (asset.Cost == cost)
                {
                    Discards[asset] = 1;
                }
            }
        }

        /// <summary>
        /// Loads cards from source files and manual input in memory.
        /// </summary>
        /// <returns></returns>
        public static CardCollection LoadFromSources()
        {
            CardCollection coll = new CardCollection();

            coll.InDeck.AddRange(HTMLReader.GetArtifacts());
            coll.InDeck.AddRange(HTMLReader.GetAssets());
            coll.InDeck.AddRange(HTMLReader.GetConditions());
            coll.InDeck.AddRange(HTMLReader.GetSpells());
            coll.InDeck.AddRange(UniqueAssetsManual.GetAllUniqueAssets());

            Quantifier.Quantify(coll.InDeck);

            foreach (InvestigatorCard card in coll.InDeck)
            {
                coll.Discards.Add(card, 0);
            }

            return coll;
        }

        /// <summary>
        /// Loads a collection from file.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static CardCollection Load(string filepath)
        {
            using (Stream s = File.Open(filepath, FileMode.Open))
            {
                return Load(s);
            }
        }

        /// <summary>
        /// Loads a collection from a stream.
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static CardCollection Load(Stream s)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            CardCollection coll = (CardCollection)binaryFormatter.Deserialize(s);
            
            if (coll.ExpansionsInUse == null)
            {
                coll.ExpansionsInUse = new List<Expansion>() { Expansion.Core };
            }

            return coll;
        }

        /// <summary>
        /// Saves a collection to file.
        /// </summary>
        /// <param name="filepath"></param>
        public void Save(string filepath)
        {
            using (Stream s = File.Open(filepath, FileMode.Create))
            {
                Save(s);
            }
        }

        /// <summary>
        /// Saves a collection via a stream.
        /// </summary>
        /// <param name="s"></param>
        public void Save(Stream s)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(s, this);
        }
    }
}
