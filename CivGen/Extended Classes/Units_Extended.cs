using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Unit : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_UNIT_";
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
                if (Technology != null) return Technology.Era.ERA;
                if (Civic != null) return Civic.Era.ERA;

                return eERA.ANCIENT; 
                
            }
        }

        public ICollection<Technology> Tech_AllowsUnitEmbarkation { get { return Technologies; } }
        public Technology Tech_MandatoryObsoleteTech { get { return Technology1; } }
        public Technology Tech_PreRequisite { get { return Technology2; } }

        public Civic Civic_PreRequisite { get { return Civic; } }                           //And civic 3??
        public Civic Civic_ObsoleteCivic { get { return Civic2; } }                         //Not Mandatory!

        public ICollection<Unit> Unit_CaptureUnitBecomes { get { return Units; } }          //and Units1
        public ICollection<Unit> Unit_ReplacedBy_UniqueUnit { get { return Units2; } }
        public Unit Unit_UniqueUnit_Replaces_Unit { get { return Units11; } }
        public ICollection<Unit> Unit_UpgradesFrom { get { return Units3; } }
        public Unit Unit_UpgradesTo { get { return Units12; } }

        public string Building_PreRequisite
        {
            get
            {
                string output = "";
                foreach (Unit_BuildingPrereqs preReq in this.Unit_BuildingPrereqs)
                {
                    output += preReq.Building.html_Goto_URL_Link + " | ";
                }
                return (output.Length > 3) ? output.Substring(0, output.Length - 3) : output;
            }
        }

        /*
        Battering Ram has Civic2 Civil Engineering
        Siege Tower has Civic2 Civil Engineering
        */

    }
}
