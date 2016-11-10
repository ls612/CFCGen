using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public class BoostHelper
    {
        public Boost ThisBoost { get; set; }
        public BoostHelper() { }
        public BoostHelper(Boost thisBoost) { ThisBoost = thisBoost; }

        public string BoostDetails(Technology owner)
        {

        }

        private string BoostText()
        {
            if (ThisBoost == null) return "";
            switch (ThisBoost.BoostClass)
            {
                case "BOOST_TRIGGER_NUM_IMPROVED_TILES": return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString() + " " + ThisBoost.Improvement.html_Goto_URL_Link;
                case "BOOST_TRIGGER_DISCOVER_CONTINENT":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by discovering another continent.";
                case "BOOST_TRIGGER_CLEAR_CAMP":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by discovering another continent."; 
                case "BOOST_TRIGGER_HAVE_X_UNIQUE_SPECIALTY_DISTRICTS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_EMPIRE_POPULATION":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_CREATE_PANTHEON":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_RESEARCH_TECH":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_MEET_X_CITY_STATES":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_WONDERS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_DISTRICTS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_RECEIVE_DOW":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_FOUND_RELIGION":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_KILL_WITH":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_IMPROVEMENTS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_CITY_POPULATION":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_LAND_UNITS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_MAINTAIN_X_TRADE_ROUTES":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_BUILDINGS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_OWN_X_UNITS_OF_TYPE":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_TRAIN_UNIT":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_AN_ALLIANCE":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_CITIES_FOLLOWING_YOUR_RELIGION":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_GREAT_PEOPLE":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_DOW_CASUS_BELLI":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_DISTRICT_APPEAL_LEVEL_MINIMUM_X":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_CORPS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_THEMED_BUILDINGS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_AIRBASE_FOREIGN_CONTINENT":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_SETTLE_COAST":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_FIND_NATURAL_WONDER":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_MEET_CIV":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_NUM_BARBS_KILLED":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_IMPROVE_SPECIFIC_RESOURCE":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_CONSTRUCT_BUILDING":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_CULTURVATE_CIVIC":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_X_POLICY_SLOTS":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_BUILDING_MOUNTAIN":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_WONDER_PAST_X_ERA":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_CREATED_NATIONAL_PARK":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_HAVE_RESEARCH_AGREEMENT":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_ARTIFACT_EXTRACTED":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_NONE_LATE_GAME_CRITICAL_TECH":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();
                case "BOOST_TRIGGER_KILL_SPECIFIC_UNIT":
                    return "Boost of " + ThisBoost.Boost1.ToString() + ", triggered by having " + ThisBoost.NumItems.ToString();

            }

        }



    }
}
