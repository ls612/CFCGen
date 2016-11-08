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

        Yield_Helper helper; 

        public string YieldString
        {
            get
            {
                helper = new Yield_Helper(this.Improvement_YieldChanges);
                //return helper.BaseYieldString;
                return helper.YieldChangesString;
            }
        }

        public string ImprovementYieldString
        {
            get
            {
                StringBuilder improvementEffect = new StringBuilder();
                foreach (Improvement_ValidResources improvement in this.Improvement_ValidResources)
                {
                    foreach (Improvement_YieldChanges change in improvement.Improvement.Improvement_YieldChanges)
                    {
                        helper.ModifyYields(improvement.Improvement.FriendlyName, change.YieldType, change.YieldChange);
                    }
                    improvementEffect.AppendLine(improvement.Improvement.html_Goto_URL_Link + ": " + helper.ModifiedYieldString);
                }
                return improvementEffect.ToString();
            }
        }
    }
}
