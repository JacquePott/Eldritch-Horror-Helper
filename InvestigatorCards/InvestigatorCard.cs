using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.InvestigatorCards
{
    /// <summary>
    /// A card an investigator can possess.
    /// </summary>
    [Serializable]
    public class InvestigatorCard
    {
        public string Name { get; protected set; }
        public InvestigatorCardType CardType { get; protected set; }
        public Expansion Expansion { get; protected set; }
        public List<string> Traits { get; protected set; }
        protected Dictionary<Expansion, int> Quantities { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="expansion"></param>
        /// <param name="traits"></param>
        public InvestigatorCard(string name, InvestigatorCardType type, Expansion expansion, IEnumerable<string> traits)
        {
            Name = name;
            CardType = type;
            Expansion = expansion;
            Traits = new List<string>(traits);
            Quantities = new Dictionary<Expansion, int>
            {
                { expansion, 1 }
            };
        }

        /// <summary>
        /// Sets the quantity of cards of this name provided by a specific box.
        /// </summary>
        /// <param name="expansion"></param>
        /// <param name="num"></param>
        public void SetQuantity(Expansion expansion, int num)
        {
            if(num < 0) { num = 0; }
            Quantities[expansion] = num;
        }

        /// <summary>
        /// Gets the quantity of cards of this name available for the set of expansions being used.
        /// </summary>
        /// <param name="expSet"></param>
        /// <returns></returns>
        public int GetQuantity(IEnumerable<Expansion> expSet)
        {
            int num = 0;

            foreach (Expansion exp in expSet)
            {
                if (Quantities.ContainsKey(exp))
                {
                    num += Quantities[exp];
                }
            }

            return num;
        }
    }
}
