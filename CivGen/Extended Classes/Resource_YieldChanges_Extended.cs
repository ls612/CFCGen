using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Resource_YieldChanges :CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "YIELD_";
        private const string NameSuffix = "";


        public override string ReferenceName
        {
            get
            {
                return YieldType.Replace(NamePrefix, "");
            }

        }

        public override eERA ReferenceEra
        {
            get
            {
                return eERA.ANCIENT;
            }
        }
    }
}
