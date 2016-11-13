using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{

    public enum BoostDirection
    {
        TextForCivicOrTech,
        TextForOtherThatBoostsCivicOrTech,
    }

    public class BoostHelper
    {
        public Boost ThisBoost { get; set; }
        public BoostHelper() { }
        public BoostHelper(Boost thisBoost) { ThisBoost = thisBoost; }

        public string BoostDetails(Technology owner)
        {
            return "";
        }

        public string BoostText(BoostDirection direction)
        {
            string techOrCivic = "";
            if (ThisBoost.Technology != null && ThisBoost.Civic != null)
            {
                techOrCivic = (ThisBoost.Technology != null) ? ThisBoost.Technology.html_Goto_URL_Link : ThisBoost.Civic.html_Goto_URL_Link;
            }
            string boostValue = ThisBoost.Boost1.ToString() + @"%";
            string itemCount = ThisBoost.NumItems.ToString();
            if (ThisBoost == null) return "";
            #region Switch Cases
            switch (ThisBoost.BoostClass)
            {
                case "BOOST_TRIGGER_NUM_IMPROVED_TILES":
                    {
                        return "Boosts of " + boostValue + " when player has " + itemCount + " improved tiles.";
                    }
                case "BOOST_TRIGGER_DISCOVER_CONTINENT":
                    return "Boost of " + boostValue + ", triggered by discovering another continent.";
                case "BOOST_TRIGGER_CLEAR_CAMP":
                    return "Boost of " + boostValue + ", triggered by clearing a barbarian camp.";
                case "BOOST_TRIGGER_HAVE_X_UNIQUE_SPECIALTY_DISTRICTS":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " unique specialty districts.";
                case "BOOST_TRIGGER_EMPIRE_POPULATION":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " citizens.";
                case "BOOST_TRIGGER_CREATE_PANTHEON":
                    return "Boost of " + boostValue + ", triggered by founding a Pantheon";
                case "BOOST_TRIGGER_RESEARCH_TECH":
                    return "Boost of " + boostValue + ", triggered by researching the technology " + ThisBoost.Technology1.html_Goto_URL_Link;
                case "BOOST_TRIGGER_MEET_X_CITY_STATES":
                    return "Boost of " + boostValue + ", triggered by meeting " + itemCount + " City States";
                case "BOOST_TRIGGER_HAVE_X_WONDERS":
                    return "Boost of " + boostValue + ", triggered by building " + itemCount + " Great Wonders";
                case "BOOST_TRIGGER_HAVE_X_DISTRICTS":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " Districts";
                case "BOOST_TRIGGER_RECEIVE_DOW":
                    return "Boost of " + boostValue + ", if someone declares war on you.";
                case "BOOST_TRIGGER_FOUND_RELIGION":
                    return "Boost of " + boostValue + ", triggered by founding a religion.";
                case "BOOST_TRIGGER_KILL_WITH":
                    return "Boost of " + boostValue + ", triggered by killing a unit with a " + ThisBoost.Unit.html_Goto_URL_Link;
                case "BOOST_TRIGGER_HAVE_X_IMPROVEMENTS":
                    {
                        if (direction == BoostDirection.TextForCivicOrTech)
                        {
                            return boostValue + " boost, triggered by having " + itemCount + " " + ThisBoost.Improvement.html_Goto_URL_Link;
                        }
                        else
                        {
                            return "Boosts " + techOrCivic + " by " + ThisBoost.Boost1.ToString() + " when player has " + ThisBoost.NumItems.ToString() + " " + ThisBoost.Improvement.FriendlyName;
                        }
                    }
                case "BOOST_TRIGGER_CITY_POPULATION":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " citizens in a single city.";
                case "BOOST_TRIGGER_HAVE_X_LAND_UNITS":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " Land Units.";
                case "BOOST_TRIGGER_MAINTAIN_X_TRADE_ROUTES":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " Trade Routes.";
                case "BOOST_TRIGGER_HAVE_X_BUILDINGS":
                    if (direction == BoostDirection.TextForCivicOrTech)
                    {
                        return "Boost of " + boostValue + ", triggered by having " + itemCount + " " + ThisBoost.Building.html_Goto_URL_Link;
                    }
                    else
                    {
                        return "Boosts " + techOrCivic + " by " + boostValue + " when player has " + itemCount + " of this Building.";
                    }
                    
                case "BOOST_TRIGGER_OWN_X_UNITS_OF_TYPE":
                    if (direction == BoostDirection.TextForCivicOrTech)
                    {
                        return "Boost of " + boostValue + ", triggered by having " + itemCount + " " + ThisBoost.Unit.html_Goto_URL_Link;
                    }
                    else
                    {
                        return "Boosts " + techOrCivic + " by " + boostValue + " when player has " + itemCount + " of this Unit.";
                    }
                case "BOOST_TRIGGER_TRAIN_UNIT":
                    return "Boost of " + boostValue + ", triggered by gaining a " + ThisBoost.Unit.html_Goto_URL_Link;
                case "BOOST_TRIGGER_HAVE_AN_ALLIANCE":
                    return "Boost of " + boostValue + ", triggered by gaining an Alliance.";
                case "BOOST_TRIGGER_HAVE_X_CITIES_FOLLOWING_YOUR_RELIGION":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " cities following your religion.";
                case "BOOST_TRIGGER_HAVE_X_GREAT_PEOPLE":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " Great People.";
                case "BOOST_TRIGGER_DOW_CASUS_BELLI":
                    return "Boost of " + boostValue + ", triggered when war is declared against you.";
                case "BOOST_TRIGGER_DISTRICT_APPEAL_LEVEL_MINIMUM_X":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " " + ThisBoost.District.html_Goto_URL_Link + " districts";
                case "BOOST_TRIGGER_HAVE_X_CORPS":
                    return "Boost of " + boostValue + ", triggered by having " + itemCount + " Corps (stacKed units) in your Army.";
                case "BOOST_TRIGGER_HAVE_X_THEMED_BUILDINGS":
                    return "Boost of " + boostValue + ", triggered by having " + ThisBoost.NumItems.ToString() + " themed building.";
                case "BOOST_TRIGGER_AIRBASE_FOREIGN_CONTINENT":
                    return "Boost of " + boostValue + ", triggered by having " + ThisBoost.NumItems.ToString() + " airbase on a foreign continent.";
                case "BOOST_TRIGGER_SETTLE_COAST":
                    return "Boost of " + boostValue + ", triggered by settling on a coast.";
                case "BOOST_TRIGGER_FIND_NATURAL_WONDER":
                    return "Boost of " + boostValue + ", triggered by finding a Natural Wonder.";
                case "BOOST_TRIGGER_MEET_CIV":
                    return "Boost of " + boostValue + ", triggered by meeting another Civiliation.";
                case "BOOST_TRIGGER_NUM_BARBS_KILLED":
                    return "Boost of " + boostValue + ", triggered by killing " + ThisBoost.NumItems.ToString() + " barbarians.";
                case "BOOST_TRIGGER_IMPROVE_SPECIFIC_RESOURCE":
                    return "Boost of " + boostValue + ", triggered by building " + ThisBoost.NumItems.ToString() + " " + ThisBoost.Improvement.html_Goto_URL_Link + " on " + ThisBoost.Resource.html_Goto_URL_Link;
                case "BOOST_TRIGGER_CONSTRUCT_BUILDING":
                    return "Boost of " + boostValue + ", triggered by building a " + ThisBoost.Building.html_Goto_URL_Link;
                case "BOOST_TRIGGER_CULTURVATE_CIVIC":
                    return "Boost of " + boostValue + ", triggered by adopting the " + ThisBoost.Civic.html_Goto_URL_Link;
                case "BOOST_TRIGGER_HAVE_X_POLICY_SLOTS":
                    return "Boost of " + boostValue + ", triggered by having " + ThisBoost.NumItems.ToString() + " policy slots.";
                case "BOOST_TRIGGER_HAVE_BUILDING_MOUNTAIN":
                    return "Boost of " + boostValue + ", triggered by building a " + ThisBoost.Building.html_Goto_URL_Link + " on a mountain.";
                case "BOOST_TRIGGER_HAVE_WONDER_PAST_X_ERA":
                    return "Boost of " + boostValue + ", triggered by building an industrial (or later) era wonder.";
                case "BOOST_TRIGGER_CREATED_NATIONAL_PARK":
                    return "Boost of " + boostValue + ", triggered by creating a National Park.";
                case "BOOST_TRIGGER_HAVE_RESEARCH_AGREEMENT":
                    return "Boost of " + boostValue + ", triggered by having a research agreement.";
                case "BOOST_TRIGGER_ARTIFACT_EXTRACTED":
                    return "Boost of " + boostValue + ", triggered by extracting an artifact.";
                case "BOOST_TRIGGER_NONE_LATE_GAME_CRITICAL_TECH":
                    return "Boost of " + boostValue + ", by stealing this technology.";
                case "BOOST_TRIGGER_KILL_SPECIFIC_UNIT":
                    if (direction == BoostDirection.TextForCivicOrTech)
                    {
                        return "Boost of " + boostValue + ", triggered by destroying " + itemCount + " " + ThisBoost.Unit.html_Goto_URL_Link;
                    }
                    else
                    {
                        return "Boosts " + techOrCivic + " by " + boostValue + " when " + itemCount + " of this Unit is destroyed.";
                    }
            }
            #endregion
            return "Boost Text not defined.";
        }



    }
}
