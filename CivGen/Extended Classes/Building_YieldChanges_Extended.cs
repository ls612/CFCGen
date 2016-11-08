using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Building_YieldChanges : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "IMPROVEMENT_";
        private const string NameSuffix = "";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                return Building.ReferenceName;
            }
        }

        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Access to the Era.
        /// </summary>
        public override eERA ReferenceEra
        {
            get
            {
                return Building.ReferenceEra;
            }
        }

        //Want this to point to "improvement", not "Improvement_ValidResources"
        public override string OpenURL
        {
            get
            {
                return BaseURL + "Building";
            }
        }
    }
}
