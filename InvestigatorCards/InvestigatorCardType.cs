using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.InvestigatorCards
{
    /// <summary>
    /// Lists the type of investigator card this is.
    /// </summary>
    [Serializable]
    public enum InvestigatorCardType
    {
        Asset, UniqueAsset, Artifact, Spell, Condition
    }
}
