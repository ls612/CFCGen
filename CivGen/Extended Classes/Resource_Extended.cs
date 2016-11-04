using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Resource : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_RESOURCE_";
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

        public override eERA ReferenceEra
        {
            get
            {
                if (Technology != null) return Technology.ReferenceEra;
                if (Civic != null) return Civic.ReferenceEra;
                return eERA.ANCIENT; //Starting conditions.
            }
        }

        public string YieldString
        {
            get
            {
                string yield = "Food: v  |  Gold: w  |  Production: x   |  Faith: y   |  Culture: z ";
                if (Resource_YieldChanges.Count == 0) return "Food: -  |  Gold: -  |  Production: -   |  Faith: -   |  Culture: - "; ;
                foreach (Resource_YieldChanges change in this.Resource_YieldChanges)
                {
                    if (change.FriendlyName == "Food") yield = yield.Replace("Food","<b>Food</b>").Replace("v", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Gold") yield = yield.Replace("Gold", "<b>Gold</b>").Replace("w", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Production") yield = yield.Replace("Production", "<b>Production</b>").Replace("x", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Faith") yield = yield.Replace("Faith", "<b>Faith</b>").Replace("y", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Culture") yield = yield.Replace("Culture", "<b>Culture</b>").Replace("z", "<b>" + change.YieldChange.ToString() + "</b>");
                }

                return yield.Replace('v', '-').Replace('w', '-').Replace('x', '-').Replace('y', '-').Replace('z', '-');
            }
        }
    }
}
