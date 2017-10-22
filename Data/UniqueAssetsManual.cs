using EldritchHorrorHelper.InvestigatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.Data
{
    /// <summary>
    /// Contains unique assets manually entered as no table exists.
    /// </summary>
    public class UniqueAssetsManual
    {
        public static List<InvestigatorCard> GetAllUniqueAssets()
        {
            List<InvestigatorCard> cards = new List<InvestigatorCard>();

            cards.Add(new InvestigatorCard("Ace of Swords", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TRINKET", "TAROT" }));
            cards.Add(new InvestigatorCard("Agency Secrets", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "ITEM" }));
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 4);
            cards.Add(new InvestigatorCard("Agent Callahan", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Albert Wilmarth", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Amery Wendy-Smith", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Ancient Sword", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "MAGICAL", "RELIC", "WEAPON" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 1);
            cards.Add(new InvestigatorCard("Anna Tilton", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Asenath Waite", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Basil Elton", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Bury Them Deep", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.TheDreamlands, 3);
            cards.Add(new InvestigatorCard("Canopic Jar", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Constance Hawberk", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Corinna Jones", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Courier Run", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 4);
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 4);
            cards.Add(new InvestigatorCard("Cryptic Text", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ITEM", "TOME" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 4);
            cards.Add(new InvestigatorCard("Cursed Tablet", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Danforth", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Death XIII", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TRINKET", "TAROT" }));
            cards.Add(new InvestigatorCard("Dimensional Study", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.TheDreamlands, 3);
            cards.Add(new InvestigatorCard("Dr. Hiram Upham", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Duke", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "ALLY" }));
            cards.Add(new InvestigatorCard("Enlist the Masses", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.SignsOfCarcosa, 3);
            cards.Add(new InvestigatorCard("Enoch Bowen", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Erich Weiss", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Esteban Herrero", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Etienne Laurent", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Exploring the Ruins", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Add(new InvestigatorCard("Father Merluzzo", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Five of Pentacles", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TRINKET", "TAROT" }));
            cards.Add(new InvestigatorCard("Flux Stabilizer", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "ITEM" }));
            cards.Add(new InvestigatorCard("For the Greater Good", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 3);
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 3);
            cards.Add(new InvestigatorCard("Fossilized Samples", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ITEM", "RELIC" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Four of Cups", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TRINKET", "TAROT" }));
            cards.Add(new InvestigatorCard("Funding the Cause", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.SignsOfCarcosa, 3);
            cards.Add(new InvestigatorCard("Granny Orne", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Halpin Chambers", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Henry Wilcox", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Hildred Castaigne", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Invoke the Elements", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Jeweled Scarab", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "TRINKET", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Kid O'Brien", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Know Thy Enemy", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Light of Reason", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 3);
            cards.Add(new InvestigatorCard("Lost Treasure", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Mastering the Art", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.SignsOfCarcosa, 3);
            cards.Add(new InvestigatorCard("Miss Doyle", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "ALLY" }));
            cards.Add(new InvestigatorCard("Mysterious Idol", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Mythos Codex", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "ITEM", "TOME" }));
            cards.Last().SetQuantity(Expansion.TheDreamlands, 4);
            cards.Add(new InvestigatorCard("Old Journal", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ITEM", "TOME" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 4);
            cards.Add(new InvestigatorCard("Ornate Scarab", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "TRINKET", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Pharaonic Mask", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Prayer", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Add(new InvestigatorCard("Professor Armitage", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Professor Morgan", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Professor Rice", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Provisions", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ITEM" }));
            cards.Add(new InvestigatorCard("Purifying the World", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 3);
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 3);
            cards.Add(new InvestigatorCard("Randolph Carter", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Sacrifices to Make", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 3);
            cards.Add(new InvestigatorCard("Sealing the Old Ones", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 3);
            cards.Add(new InvestigatorCard("Seeking the Masters", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 3);
            cards.Add(new InvestigatorCard("Sir William Brinton", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Stone Calendar", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "MAGICAL", "RELIC" }));
            cards.Add(new InvestigatorCard("Stone Chest", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "RELIC" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Add(new InvestigatorCard("Stone Tablet", InvestigatorCardType.UniqueAsset, Expansion.StrangeRemnants, new string[] { "ITEM", "RELIC" }));
            cards.Last().SetQuantity(Expansion.StrangeRemnants, 3);
            cards.Add(new InvestigatorCard("The Moon XVIII", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TRINKET", "TAROT" }));
            cards.Add(new InvestigatorCard("Treasure Map", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "TRINKET" }));
            cards.Last().SetQuantity(Expansion.UnderThePyramids, 4);
            cards.Add(new InvestigatorCard("Turning the Tide", InvestigatorCardType.UniqueAsset, Expansion.SignsOfCarcosa, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.SignsOfCarcosa, 3);
            cards.Add(new InvestigatorCard("Unspeakable Research", InvestigatorCardType.UniqueAsset, Expansion.TheDreamlands, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.TheDreamlands, 3);
            cards.Add(new InvestigatorCard("Walking the Ley Lines", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.MountainsOfMadness, 3);
            cards.Last().SetQuantity(Expansion.TheDreamlands, 3);
            cards.Add(new InvestigatorCard("Wave of Destruction", InvestigatorCardType.UniqueAsset, Expansion.CitiesInRuin, new string[] { "TASK" }));
            cards.Last().SetQuantity(Expansion.CitiesInRuin, 3);
            cards.Add(new InvestigatorCard("William Dyer", InvestigatorCardType.UniqueAsset, Expansion.MountainsOfMadness, new string[] { "ALLY", "CHARACTER" }));
            cards.Add(new InvestigatorCard("Wooden Puppet", InvestigatorCardType.UniqueAsset, Expansion.UnderThePyramids, new string[] { "ALLY", "MAGICAL", "RELIC" }));

            return cards;
        }
    }
}
