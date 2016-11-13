using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Government : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_GOVERNMENT_";
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
                if (this.Civic == null) return eERA.ANCIENT;
                return this.Civic.Era.ERA;
            }
        }

        public string Bonuses
        {
            get
            {
                return "";
                /*
                StringBuilder output = new StringBuilder();
                switch (this.Bonuses)
                {
                    case "GOVERNMENTBONUS_DISTRICT_PROJECTS":
                        output.AppendLine("All cities with a district receive +1 Icon Amenities.png Amenity");
                        break;
                }

                
"GOVERNMENTBONUS_OVERALL_PRODUCTION"
"GOVERNMENTBONUS_UNIT_PRODUCTION"
"GOVERNMENTBONUS_GOLD_PURCHASES"
"GOVERNMENTBONUS_FAITH_PURCHASES"
"GOVERNMENTBONUS_ENVOYS"
"GOVERNMENTBONUS_GREAT_PEOPLE"
"GOVERNMENTBONUS_COMBAT_EXPERIENCE"
"GOVERNMENTBONUS_WONDER_CONSTRUCTION"
"NO_GOVERNMENTBONUS"*/
            }
        }

    }
}
