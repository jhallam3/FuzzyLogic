using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionsFramework.Design.Flow;
using FuzzySharp;

namespace DecisionsFuzzyClass
{
    [AutoRegisterMethodsOnClass(true, "Integration", "Fuzzy", RegisterForAgents = true)]
    public class FuzzyDecisions
    {
        public int SimpleRatio(string input1, string input2)
        {
            var f = Fuzz.Ratio(input1,input2);
            return f;
        }

        public int ParialRatio(string input1, string input2)
        {
            var f = Fuzz.PartialRatio(input1, input2);
            return f;
        }
    }

}
