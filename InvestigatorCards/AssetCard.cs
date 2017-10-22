using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.InvestigatorCards
{
    /// <summary>
    /// Asset cards with added field for cost.
    /// </summary>
    [Serializable]
    public class AssetCard : InvestigatorCard
    {
        public int Cost { get; protected set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="expansion"></param>
        /// <param name="traits"></param>
        /// <param name="cost"></param>
        public AssetCard(string name, InvestigatorCardType type, Expansion expansion, IEnumerable<string> traits, int cost) : 
            base(name, type, expansion, traits)
        {
            Cost = cost;
        }
    }
}
