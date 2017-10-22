using EldritchHorrorHelper.InvestigatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.Data
{
    /// <summary>
    /// Adds quantities by expansion to cards that don't have that set.
    /// </summary>
    public class Quantifier
    {
        /// <summary>
        /// Adds proper quantities to investigator cards.
        /// </summary>
        /// <param name="cards"></param>
        public static void Quantify(IEnumerable<InvestigatorCard> cards)
        {
            foreach (InvestigatorCard card in cards)
            {
                //Only alter spells and conditions - all other cards either only have one copy or are quantified in initial loading
                if (card.CardType == InvestigatorCardType.Spell)
                {
                    if (card.Expansion == Expansion.Core)
                    {
                        card.SetQuantity(Expansion.Core, 2);
                        card.SetQuantity(Expansion.ForsakenLore, 2);
                    }
                    else
                    {
                        card.SetQuantity(card.Expansion, 4);
                    }
                }
                else if (card.CardType == InvestigatorCardType.Condition)
                {
                    if (card.Expansion == Expansion.Core)
                    {
                        card.SetQuantity(Expansion.Core, 3);

                        switch (card.Name)
                        {
                            case "Amnesia":
                                foreach (Expansion exp in new Expansion[] { Expansion.ForsakenLore, Expansion.MountainsOfMadness, Expansion.UnderThePyramids })
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Back Injury":
                                foreach (Expansion exp in new Expansion[] { Expansion.ForsakenLore, Expansion.UnderThePyramids })
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Blessed":
                            case "Cursed":
                                card.SetQuantity(Expansion.ForsakenLore, 3);
                                foreach (Expansion exp in new Expansion[] { Expansion.MountainsOfMadness, Expansion.UnderThePyramids, Expansion.StrangeRemnants,
                                    Expansion.SignsOfCarcosa, Expansion.CitiesInRuin})
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Dark Pact":
                                foreach (Expansion exp in new Expansion[] { Expansion.MountainsOfMadness, Expansion.TheDreamlands, Expansion.StrangeRemnants,
                                    Expansion.SignsOfCarcosa, Expansion.CitiesInRuin, Expansion.ForsakenLore})
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Debt":
                                card.SetQuantity(Expansion.Core, 6);
                                card.SetQuantity(Expansion.ForsakenLore, 2);
                                card.SetQuantity(Expansion.MountainsOfMadness, 2);
                                foreach (Expansion exp in new Expansion[] { Expansion.SignsOfCarcosa, Expansion.StrangeRemnants, Expansion.SignsOfCarcosa,
                                    Expansion.CitiesInRuin})
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Detained":
                            case "Internal Injury":
                                foreach (Expansion exp in new Expansion[] { Expansion.ForsakenLore, Expansion.MountainsOfMadness })
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Hallucinations":
                                foreach (Expansion exp in new Expansion[] { Expansion.ForsakenLore, Expansion.TheDreamlands })
                                {
                                    card.SetQuantity(exp, 1);
                                }
                                break;
                            case "Leg Injury":
                            case "Paranoia":
                                card.SetQuantity(Expansion.ForsakenLore, 1);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (card.Traits.Contains("TALENT"))
                        {
                            card.SetQuantity(card.Expansion, 2);
                            
                            //Extra cards from other expansions
                            if (card.Name.Equals("Elusive") ||
                                card.Name.Equals("Martial Prowess"))
                            {
                                card.SetQuantity(Expansion.TheDreamlands, 2);
                            }
                            else if (card.Name.Equals("Quick Study"))
                            {
                                card.SetQuantity(Expansion.CitiesInRuin, 2);
                            }
                        }
                        else
                        {
                            if (card.Name.Equals("Hypothermia"))
                            {
                                card.SetQuantity(card.Expansion, 8);
                            }
                            else
                            {
                                card.SetQuantity(card.Expansion, 4);
                            }

                            //Extra cards from other expansions
                            if (card.Name.Equals("Lost in Time and Space", StringComparison.InvariantCultureIgnoreCase))
                            {
                                card.SetQuantity(Expansion.TheDreamlands, 4);
                            }
                        }
                    }
                }
            }
        }
    }
}
