using EldritchHorrorHelper.InvestigatorCards;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.Data
{
    /// <summary>
    /// Reads HTML tables from EH wiki to parse each card of a type.
    /// </summary>
    public class HTMLReader
    {
        private static readonly string SRC_DIR = "E:\\workAndCollege\\eldritch\\EHHelper\\src\\";

        /// <summary>
        /// Reads all artifacts from file.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvestigatorCard> GetArtifacts()
        {
            string file = "artifacts.txt";
            return Parse(SRC_DIR + file, InvestigatorCardType.Artifact);
        }

        /// <summary>
        /// Reads all assets from file.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvestigatorCard> GetAssets()
        {
            string file = "assets.txt";
            return Parse(SRC_DIR + file, InvestigatorCardType.Asset);
        }

        /// <summary>
        /// Reads all spells from file.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvestigatorCard> GetSpells()
        {
            string file = "spells.txt";
            return Parse(SRC_DIR + file, InvestigatorCardType.Spell);
        }

        /// <summary>
        /// Reads all conditions from file.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<InvestigatorCard> GetConditions()
        {
            string file = "conditions.txt";
            return Parse(SRC_DIR + file, InvestigatorCardType.Condition);
        }

        /// <summary>
        /// Parses a HTML table in file to get all the card data listed within.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static IEnumerable<InvestigatorCard> Parse(string filepath, InvestigatorCardType type)
        {
            List<InvestigatorCard> cards = new List<InvestigatorCard>();
            HtmlDocument doc = new HtmlDocument();
            doc.Load(filepath);

            foreach (HtmlNode rowNode in doc.DocumentNode.Descendants("tr"))
            {
                IEnumerable<HtmlNode> cardNodes = rowNode.Descendants("td");
                string name = cardNodes.ElementAt(0).InnerText.Trim();
                string traitsString = cardNodes.ElementAt(1).InnerText.Replace('-', ',').Replace('—', ',');
                HtmlNode expNode = cardNodes.ElementAt(2);
                HtmlNode expLinkNode = expNode.SelectSingleNode(".//a");
                string expString = "Core";

                if (expLinkNode != null)
                {
                    expString = expLinkNode.GetAttributeValue("title", "Core");
                }

                List<string> traits = new List<string>();
                foreach (string traitRaw in traitsString.Split(','))
                {
                    traits.Add(traitRaw.ToUpper().Trim());
                }

                Expansion exp = ExpansionExtensions.FromString(expString);
                InvestigatorCard card;

                if (type == InvestigatorCardType.Asset)
                {
                    int cost = int.Parse(cardNodes.ElementAt(3).InnerText);
                    card = new AssetCard(name, type, exp, traits, cost);
                }
                else
                {
                    card = new InvestigatorCard(name, type, exp, traits);
                }

                cards.Add(card);
            }

            return cards;
        }
    }
}
