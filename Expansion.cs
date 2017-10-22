using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper
{
    /// <summary>
    /// Notes which box a game component comes from.
    /// </summary>
    [Serializable]
    public enum Expansion
    {
        Core, ForsakenLore, MountainsOfMadness, StrangeRemnants, UnderThePyramids, SignsOfCarcosa, TheDreamlands, CitiesInRuin, MasksOfNyarlathotep
    }

    public static class ExpansionExtensions
    {
        /// <summary>
        /// Gets an expansion enum value for a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Expansion FromString(string s)
        {
            switch(s)
            {
                case "Core":
                case "Eldritch Horror":
                    return Expansion.Core;
                case "Forsaken Lore":
                    return Expansion.ForsakenLore;
                case "Mountains of Madness":
                    return Expansion.MountainsOfMadness;
                case "Strange Remnants":
                    return Expansion.StrangeRemnants;
                case "Under the Pyramids":
                    return Expansion.UnderThePyramids;
                case "Signs of Carcosa":
                    return Expansion.SignsOfCarcosa;
                case "The Dreamlands":
                    return Expansion.TheDreamlands;
                case "Cities in Ruin":
                    return Expansion.CitiesInRuin;
                case "Masks of Nyarlathotep":
                    return Expansion.MasksOfNyarlathotep;
                default:
                    throw new Exception(string.Format("Unknown value {0}!", s));
            }
        }

        public static IEnumerable<Expansion> GetAllExpansions()
        {
            List<Expansion> list = new List<Expansion>();

            foreach (Expansion exp in Enum.GetValues(typeof(Expansion)))
            {
                list.Add(exp);
            }

            return list;
        }
    }
}
