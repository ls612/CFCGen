using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Government_SlotCounts : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_SLOT_";
        private const string NameSuffix = "_NAME";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                return this.Government.ReferenceName;
            }
        }

        public override eERA ReferenceEra
        {
            get
            {
                return this.Government.ReferenceEra;
            }
        }

        public string SlotTypeFriendlyName { get { return this.GovernmentSlotType.Replace("SLOT_", "").ToTitleCase(); } }
    }
}
