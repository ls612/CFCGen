using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Improvement : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_IMPROVEMENT_";
        private const string NameSuffix = "_NAME";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                return Name.Replace(NamePrefix, "").Replace(NameSuffix, "");
            }
        }

        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Access to the Era.
        /// </summary>
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
