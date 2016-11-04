using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Boost : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_BOOST_TRIGGER_";
        private const string NameSuffix = "";


        public override string ReferenceName
        {
            get
            {
                return TriggerDescription.Replace(NamePrefix, "").Replace(NameSuffix, "");
            }

        }

        public override eERA ReferenceEra
        {
            get
            {
                if (this.Technology != null) return Technology.Era.ERA;
                if (this.Civic != null) return Civic.Era.ERA;
                return eERA.ANCIENT;
            }
        }
    }
}
