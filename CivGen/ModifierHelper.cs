using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    /// <summary>
    /// Helper class for extracting useful information from Modifiers
    /// </summary>
    public class ModifierHelper
    {
        public ICollection<Modifier> ModifierList { get; set; }
        public ICollection<ModifierArgument> ModifierArgumentList { get; set; }
        public ICollection<ModifierString> ModifierStringList { get; set; }
        public ICollection<GreatPersonIndividualActionModifier> GreatPersonActionModifiers { get; set; }
        public ICollection<CivicModifier> CivicModifiers { get; set; }

        public ModifierHelper(ICollection<Modifier> modifierList, ICollection<ModifierArgument> modifierArgumentList, ICollection<ModifierString> modifierStringList, ICollection<GreatPersonIndividualActionModifier> greatPersonActionModifiers,
            ICollection<CivicModifier> civicModifiers)
        {
            ModifierList = modifierList;
            ModifierArgumentList = modifierArgumentList;
            ModifierStringList = modifierStringList;
            GreatPersonActionModifiers = greatPersonActionModifiers;
            CivicModifiers = civicModifiers;
        }

        public string GetModifierTextForTechnology(Technology tech)
        {
            List<string> output = new List<string>();
            string description = "";
            foreach (TechnologyModifier techModifier in tech.TechnologyModifiers)
            {
                switch (techModifier.ModifierId)
                {
                    case ("MATHEMATICS_ADJUST_SEA_MOVEMENT"):
                        
                        description =("Increases Sea Movement by 1.");
                        break;
                    case ("CARTOGRAPHY_GRANT_OCEAN_NAVIGATION"):
                        description =("Allows units to traverse Ocean.");
                        break;
                    case ("CARTOGRAPHY_ADJUST_EMBARKED_MOVEMENT"):
                        description =("Increases Sea Movement by 1.");
                        break;
                    case ("STEAM_POWER_ADJUST_EMBARKED_MOVEMENT"):
                        description =("Increases Sea Movement by 1.");
                        break;
                    case ("COMBUSTION_ADJUST_EMBARKED_MOVEMENT"):
                        description =("Increases Sea Movement by 1.");
                        break;
                    case ("PRINTING_ADD_DIPLO_VISIBILITY"):
                        description =("Allows visibility of foreign lands with appropriate treaty.");
                        break;
                    case ("TECH_GRANT_SPY"):
                        description =("Allows a free spy.");
                        break;
                    case ("PRINTING_BOOST_WRITING_TOURISM"):
                        description =("Increases tourism for Writing Great Works by 200%.");
                        break;
                    case ("COMPUTERS_BOOST_ALL_TOURISM"):
                        description =("Increases tourism for all Great Works by 100%.");
                        break;
                }
                if (!output.Contains(description)) output.Add(description);
                
                /*
                //Check whether it is of a name of form "TECHNAME_MODIFIER_DETAILS".
                List<ModifierArgument> modifierArguments = ModifierArgumentList.Where(x => x.ModifierId == techModifier.ModifierId).ToList();
                if (modifierArguments.Count != 0)
                {
                    foreach (ModifierArgument argument in modifierArguments)
                    {
                        string[] argumentString = argument.ModifierId.Split('_');
                        if (argumentString[0] == tech.ReferenceName)
                        {
                            if (argument.Value != null)
                            {
                                output.AppendLine(Concantenate(argumentString, 1, argumentString.Length, " ") + " by " + argument.Value.ToString());
                            }
                            else
                            {
                                output.AppendLine(Concantenate(argumentString, 1, argumentString.Length, " "));
                            }
                        }
                    }
                }
                else
                {

                }
                 */
            }

            return String.Join(Environment.NewLine, output.ToArray());
        }

        private string Concantenate(string[] input, int start, int end, string spacer)
        {
            string output = "";
            for (int i = start; i < end; i++)
            {
                output += input[i] + spacer;
            }
            //trim last spacer
            return output.Substring(0, output.Length - spacer.Length);
        }

        /*
        "TECH_MATHEMATICS"	    "MATHEMATICS_ADJUST_SEA_MOVEMENT"
        "TECH_CARTOGRAPHY"	    "CARTOGRAPHY_GRANT_OCEAN_NAVIGATION"
        "TECH_CARTOGRAPHY"	    "CARTOGRAPHY_ADJUST_EMBARKED_MOVEMENT"
        "TECH_STEAM_POWER"	    "STEAM_POWER_ADJUST_EMBARKED_MOVEMENT"
        "TECH_COMBUSTION"	    "COMBUSTION_ADJUST_EMBARKED_MOVEMENT"
        "TECH_PRINTING"	        "PRINTING_ADD_DIPLO_VISIBILITY"
        "TECH_COMPUTERS"	    "TECH_GRANT_SPY"
        "TECH_PRINTING"	        "PRINTING_BOOST_WRITING_TOURISM"
        "TECH_COMPUTERS"	    "COMPUTERS_BOOST_ALL_TOURISM"






        */

        public string GetModifierTextForResource(Resource resource)
        {
            StringBuilder output = new StringBuilder();
            List<ModifierArgument> resourceArguments = ModifierArgumentList.Where(x => x.Value == "RESOURCE_" + resource.ReferenceName).ToList();
            if (resourceArguments.Count != 0)
            {
                //Get Modifiers
                foreach (ModifierArgument argument in resourceArguments)
                {
                    Modifier modifier = ModifierList.First(x => x.ModifierId == argument.ModifierId);
                    {
                        if (modifier != null)
                        {
                            if (modifier.ModifierType == "MODIFIER_PLAYER_ADJUST_FREE_RESOURCE_IMPORT")
                            {
                                //Granted by trade with city states
                                string text = "A free resource import can be gained from the City State of " + modifier.ModifierId.Split('_')[2];
                                if (modifier.SubjectRequirementSetId != null)
                                {
                                    text += ", provided that " + modifier.SubjectRequirementSetId.ToTitleCase();
                                }
                                output.AppendLine(text);
                                
                            }
                            if (modifier.ModifierType == "MODIFIER_PLAYER_OWNED_BONUS_RESOURCE_EXTRA_AMENITIES")
                            {
                                //Granted by trade with city states
                                string text = "Extra amenities can be gained from the City State of " + modifier.ModifierId.Split('_')[2];
                                if (modifier.SubjectRequirementSetId != null)
                                {
                                    text += ", provided that " + modifier.SubjectRequirementSetId.ToTitleCase();
                                }
                                output.AppendLine(text);

                            }
                            

                            if (modifier.ModifierType == "MODIFIER_SINGLE_CITY_GRANT_RESOURCE_IN_CITY")
                            {
                                //Granted by Great Person
                                List<GreatPersonIndividualActionModifier> actionModifiers = GreatPersonActionModifiers.Where(x => x.ModifierId == modifier.ModifierId).ToList();
                                foreach (GreatPersonIndividualActionModifier actionMod in actionModifiers)
                                {
                                    resource.GrantedByGreatPerson.Add(actionMod.GreatPersonIndividual);

                                    string text = "A free resource can be gained from the Great Person " + actionMod.GreatPersonIndividual.html_Goto_URL_Link;
                                    if (modifier.SubjectRequirementSetId != null)
                                    {
                                        text += ", provided that " + modifier.SubjectRequirementSetId.ToTitleCase();
                                    }
                                    output.AppendLine(text);
                                    
                                }
                            }
                            if (modifier.ModifierType == "MODIFIER_PLAYER_GRANT_FREE_RESOURCE_VISIBILITY")
                            {
                                //Made Visible by Great Person
                                List<GreatPersonIndividualActionModifier> actionModifiers = GreatPersonActionModifiers.Where(x => x.ModifierId == modifier.ModifierId).ToList();
                                foreach (GreatPersonIndividualActionModifier actionMod in actionModifiers)
                                {
                                    resource.MadeVisibleByGreatPerson.Add(actionMod.GreatPersonIndividual);

                                    string text = "The resource can be found by the Great Person " + actionMod.GreatPersonIndividual.html_Goto_URL_Link;
                                    if (modifier.SubjectRequirementSetId != null)
                                    {
                                        text += ", provided that " + modifier.SubjectRequirementSetId.ToTitleCase();
                                    }
                                    output.AppendLine(text);
                                }
                            }
                            if (modifier.ModifierType == "MODIFIER_PLAYER_GRANT_FREE_RESOURCE_FROM_UNIT_PLOT")
                            {
                                //Made Visible by Great Person
                                List<GreatPersonIndividualActionModifier> actionModifiers = GreatPersonActionModifiers.Where(x => x.ModifierId == modifier.ModifierId).ToList();
                                foreach (GreatPersonIndividualActionModifier actionMod in actionModifiers)
                                {
                                    resource.GrantFreeResourceFromUnitPlotByGreatPerson.Add(actionMod.GreatPersonIndividual);

                                    string text = "Additional resource can be granted from from a plot by the Great Person " + actionMod.GreatPersonIndividual.html_Goto_URL_Link;
                                    if (modifier.SubjectRequirementSetId != null)
                                    {
                                        text += ", provided that " + modifier.SubjectRequirementSetId.ToTitleCase();
                                    }
                                    output.AppendLine(text);
                                }
                            }

                        }
                    }
                }
                return output.ToString();
            }
            else
            {
                return "";
            }
        }

        /*
        //Modifer Arguments Table
            //ModifierID                                Name            Type                Value
            
            "MINOR_CIV_ZANZIBAR_CLOVES_RESOURCE_BONUS"	"ResourceType"	"ARGTYPE_IDENTITY"	"RESOURCE_CLOVES"
            "GREATPERSON_GRANT_COSMETICS"	            "ResourceType"	"ARGTYPE_IDENTITY"	"RESOURCE_COSMETICS"

        //Modifiers Table
            //ModifierID                                ModifierType    
            "MINOR_CIV_ZANZIBAR_CLOVES_RESOURCE_BONUS"	"MODIFIER_PLAYER_ADJUST_FREE_RESOURCE_IMPORT"
            "GREATPERSON_GRANT_COSMETICS"	            "MODIFIER_SINGLE_CITY_GRANT_RESOURCE_IN_CITY"

    */

    }
}
