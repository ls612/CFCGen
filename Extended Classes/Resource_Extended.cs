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
                if (GrantedByGreatPerson.Count != 0)
                {
                    return GrantedByGreatPerson[0].Era.ERA;
                }
                if (MadeVisibleByGreatPerson.Count != 0)
                {
                    return MadeVisibleByGreatPerson[0].Era.ERA;
                }
                if (MadeVisibleByCivic.Count != 0)
                {
                    return MadeVisibleByCivic[0].Era.ERA;
                }
                return eERA.ANCIENT; //Starting conditions.
            }
        }

        Yield_Helper helper = new Yield_Helper();

        public string YieldString
        {
            get
            {
                foreach (Resource_YieldChanges change in this.Resource_YieldChanges)
                {
                    helper.SetInitial(change.YieldType, change.YieldChange);
                }
                return helper.BaseYieldString;
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



        public string Type
        {
            get
            {
                return this.ResourceClassType.Replace("RESOURCECLASS_", "").ToTitleCase();
            }
        }

        /*-- Populated in 'ModiferHelper --*/
        public List<GreatPersonIndividual> GrantedByGreatPerson { get; set; } = new List<GreatPersonIndividual>();
        public List<GreatPersonIndividual> MadeVisibleByGreatPerson { get; set; } = new List<GreatPersonIndividual>();
        public List<GreatPersonIndividual> GrantFreeResourceFromUnitPlotByGreatPerson { get; set; } = new List<GreatPersonIndividual>();
        public List<Civic> MadeVisibleByCivic { get; set; } = new List<Civic>();
        public List<Civic> AllowsExtractionByCivic { get; set; } = new List<Civic>();
    }
}
