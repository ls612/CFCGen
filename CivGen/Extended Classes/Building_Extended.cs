﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    
    public partial class Building : CivBase
    {
        /*
        Buildings have a “BuildingModifiers” collection.  Each “BuildingModifier” is a basic class with a “ModifierID”.

        To get the actual Modifier, the ModifierID must be used as a lookup in the “Modifiers” class.  I have set this such that 
        a “GetModifier” method in the BuildingModifier class can get this modifier, provided that it has been passed a collection of all modifiers.

        To get the effects of the modifier, the ModifierID can be passed to the ModifierArguments class.  I have set this such that 
        a “GetModifier” method in the BuildingModifier class can get this modifier, provided that it has been passed a collection of all modifiers.
        

    */


        //Friendly aliases
        public ICollection<Building> PreRequisiteBuilding { get { return Buildings; } }
        public ICollection<Building> AllowsBuilding { get { return Buildings1; } }
        public ICollection<Building> ReplacedByBuilding { get { return Buildings11; } }
        public Building ReplacesBuilding { get { return Building1; } }

        public ICollection<Building> MutuallyExclusiveWith { get { return Buildings12; } }
        public ICollection<Building> MutuallyExclusiveFor { get { return Buildings2; } }

        public ICollection<Feature> RequiredFeatures { get { return Features; } }
        public ICollection<Feature> AllowedFeatures { get { return Features1; } }






        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_BUILDING_";
        private const string NameSuffix = "_NAME";


        /// <summary>
        /// ABSTRACT - MUST BE IMPLEMENTED:  Friendly name for the class instance in the html output.
        /// </summary>
        public override string ReferenceName
        {
            get
            {
                return Name.Replace(NamePrefix,"").Replace(NameSuffix,"");
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
                if (RequiredDistrict != null) return RequiredDistrict.ReferenceEra;
                return eERA.ANCIENT;
            }
        }


        public string GenerateHTML()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(html_Header_With_Anchor(HeaderType.h2));

            //District
            string district = (District != null) ? District.html_Goto_URL_Link : " {Any} ";
            output.AppendLine("\t" + "District:\t" + district);
            
            return output.ToString();            
        }

        public string Restrictions
        {
            get
            {
                StringBuilder restrictions = new StringBuilder();
                if (this.AdjacentToMountain) restrictions.AppendLine("Must be next to a mountain.<br>");
                if (this.Coast == true) restrictions.AppendLine("Must be located on the coast.<br>");
                if (this.MustBeAdjacentLand) restrictions.AppendLine("Must be adjacent to land.<br>");
                if (this.MustBeLake) restrictions.AppendLine("Must be located on a lake.<br>");
                if (this.MustNotBeLake) restrictions.AppendLine("Can not be located on a lake.<br>");
                if (this.MustPurchase) restrictions.AppendLine("Must be purchased.<br>");
                if (this.RequiresAdjacentRiver) restrictions.AppendLine("Must be next to a river.<br>");
                if (this.RequiresRiver) restrictions.AppendLine("Must be on a river.<br>");
                if (this.RequiresReligion) restrictions.AppendLine("Requires a religion.<br>");
                //if (this.RequiresPlacement) restrictions.AppendLine("Requires a placement.<br>");
                return restrictions.ToString();
            }
        }

        public string Effects(ICollection<Modifier> allModifiers, ICollection<ModifierArgument> allModifierArguments)
        {
           
            StringBuilder effects = new StringBuilder();
            foreach (BuildingModifier buildingModifier in BuildingModifiers)
            {
                Modifier baseModifier = buildingModifier.GetModifier(allModifiers);
                ICollection<ModifierArgument> baseModifierArguments = buildingModifier.GetModifierArguments(allModifierArguments);
                if (baseModifier.SubjectRequirementSetId == null)
                {
                    effects.AppendLine(baseModifierArguments.First().Value);
                }
                else
                {
                    effects.AppendLine("If " + baseModifier.SubjectRequirementSetId.Replace('_', ' ').ToLower() + " then " + baseModifierArguments.First().Value);
                }
            }
            return effects.ToString();
           
        }

        public string GreatWorkSlotText
        {
            get
            {
                string output = "";
                foreach (Building_GreatWorks greatWork in Building_GreatWorks)
                {
                    output += greatWork.GreatWorkSlotType1.FriendlyName + ": " + greatWork.NumSlots.ToString() + " | ";
                }
                return (output.Length > 3) ? output.Substring(0, output.Length - 3) : output;
            }
        }

        public string GreatPersonPointsText
        {
            get
            {
                string output = "";
                foreach (Building_GreatPersonPoints greatPersonType in Building_GreatPersonPoints)
                {
                    output += greatPersonType.GreatPersonClass.FriendlyName + ": +" + greatPersonType.PointsPerTurn.ToString() + " | ";
                }
                return (output.Length > 3) ? output.Substring(0, output.Length - 3) : output;
            }
        }

        public override string URL
        {
            get
            {
                try
                {
                    //return BaseURL + this.GetType().BaseType.Name + @"/";
                    if (IsWonder) return BaseURL + "Wonder" + @"/";
                }
                catch
                { }
                return base.URL;
            }
        }

        public override string OpenURL
        {
            get
            {
                try
                {
                    //return BaseURL + this.GetType().BaseType.Name;
                    if (IsWonder) return BaseURL + "Wonder";
                }
                catch { }
                return base.OpenURL;
            }
        }

        public District RequiredDistrict { get { return District; } }
        public District RequiredAdjacentDistrict { get { return District1; } }
    }
   
}
