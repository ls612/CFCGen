using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Unit_BuildingPrereqs : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "UNIT_";
        private const string NameSuffix = "";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                return Unit.Replace(NamePrefix, "");
            }
        }

        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Access to the Era.
        /// </summary>
        public override eERA ReferenceEra
        {
            get
            {
                return eERA.ANCIENT;

            }
        }
    }
}
