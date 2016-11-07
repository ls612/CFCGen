using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class BarbarianTribe : CivBase
    {

        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "TRIBE_";
        private const string NameSuffix = "";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                
                return TribeType.Replace(NamePrefix, "");
            }
        }

        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Access to the Era.
        /// </summary>
        public override eERA ReferenceEra
        {
            get
            {

                if (this.Resource == null) return eERA.ANCIENT;
                return Resource.ReferenceEra;
            }
        }
    }
}
