using EldritchHorrorHelper.InvestigatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldritchHorrorHelper.Data
{
    /// <summary>
    /// User-inputted predicate to check traits of cards.
    /// </summary>
    public class TraitPredicate
    {
        private LogicalParameter lp;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="s"></param>
        public TraitPredicate(string s)
        {
            lp = Parse(s);
        }

        /// <summary>
        /// Returns true if the card matches the predicate.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool IsValid(InvestigatorCard card)
        {
            return lp.IsMatch(card.Traits);
        }

        /// <summary>
        /// Parses a logical parameter from a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private LogicalParameter Parse(string s)
        {
            List<LogicalParameter> components = new List<LogicalParameter>();
            bool inOr = false;
            string currentTrait = "";

            foreach (char c in s)
            {
                if (c == '(')
                {
                    inOr = true;
                }
                else if (c == ')')
                {
                    inOr = false;
                    AndStatement and = (AndStatement)Parse(currentTrait);
                    OrStatement or = new OrStatement(and.Components);
                    components.Add(or);
                    currentTrait = "";
                }
                else if (c == ' ' && !inOr)
                {
                    components.Add(new Atom(currentTrait));
                    currentTrait = "";
                }
                else
                {
                    currentTrait += c;
                }
            }

            if (currentTrait != "")
            {
                components.Add(new Atom(currentTrait));
            }

            return new AndStatement(components);
        }

        /// <summary>
        /// Logical parameter interface.
        /// </summary>
        internal interface LogicalParameter
        {
            bool IsMatch(IEnumerable<string> traits);
        }

        /// <summary>
        /// Atomic logical parameter.
        /// </summary>
        internal class Atom : LogicalParameter
        {
            public string Trait;

            public Atom(string s)
            {
                Trait = s;
            }

            public bool IsMatch(IEnumerable<string> traits)
            {
                foreach (string s in traits)
                {
                    if (s.Equals(Trait, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        /// Multiple other logical parameters in an and statement.
        /// </summary>
        internal class AndStatement : LogicalParameter
        {
            public List<LogicalParameter> Components;

            public AndStatement(IEnumerable<LogicalParameter> lp)
            {
                Components = new List<LogicalParameter>(lp);
            }

            public bool IsMatch(IEnumerable<string> traits)
            {
                foreach (LogicalParameter lp in Components)
                {
                    if (!lp.IsMatch(traits))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// Multiple other logical parameters in an or statement.
        /// </summary>
        internal class OrStatement : LogicalParameter
        {
            public List<LogicalParameter> Components;

            public OrStatement(IEnumerable<LogicalParameter> lp)
            {
                Components = new List<LogicalParameter>(lp);
            }

            public bool IsMatch(IEnumerable<string> traits)
            {
                foreach (LogicalParameter lp in Components)
                {
                    if (lp.IsMatch(traits))
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
