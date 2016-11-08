using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public class Yield_Helper
    {

        public long Food { get; set; } = 0;
        public long Gold { get; set; } = 0;
        public long Production { get; set; } = 0;
        public long Faith { get; set; } = 0;
        public long Culture { get; set; } = 0;
        public long Science { get; set; } = 0;

        public long ModifiedFood { get; set; } = 0;
        public long ModifiedGold { get; set; } = 0;
        public long ModifiedProduction { get; set; } = 0;
        public long ModifiedFaith { get; set; } = 0;
        public long ModifiedCulture { get; set; } = 0;
        public long ModifiedScience { get; set; } = 0;

        public string Modifier { get; set; } = "";


        public Yield_Helper(ICollection<Building_YieldChanges> buildingChanges)
        {
            foreach (Building_YieldChanges change in buildingChanges)
            {
                ModifyYields(change.YieldType, change.YieldChange);
            }
        }

        public Yield_Helper(ICollection<Improvement_YieldChanges> improvementChanges)
        {
            foreach (Improvement_YieldChanges change in improvementChanges)
            {
                ModifyYields(change.YieldType, change.YieldChange);
            }
        }

        public Yield_Helper(ICollection<Resource_YieldChanges> resourceChanges)
        {
            foreach (Resource_YieldChanges change in resourceChanges)
            {
                ModifyYields(change.YieldType, change.YieldChange);
            }
        }


        public void SetInitial(string yield, long value)
        {
            switch (yield)
            {
                case "YIELD_FOOD":
                    Food = value;
                    break;
                case "YIELD_GOLD":
                    Gold = value;
                    break;
                case "YIELD_PRODUCTION":
                    Production = value;
                    break;
                case "YIELD_FAITH":
                    Faith = value;
                    break;
                case "YIELD_CULTURE":
                    Culture = value;
                    break;
                case "YIELD_SCIENCE":
                    Science = value;
                    break;
            }
        }

        public void ModifyYields(string yield, long value)
        {
            ModifyYields("", yield, value);
        }
        public void ModifyYields(string modifier, string yield, long value)
        {
            Modifier = modifier;
            switch (yield)
            {
                case "YIELD_FOOD":
                    ModifiedFood = Food + value;
                    break;
                case "YIELD_GOLD":
                    ModifiedGold =  Gold + value;
                    break;
                case "YIELD_PRODUCTION":
                    ModifiedProduction = Production + value;
                    break;
                case "YIELD_FAITH":
                    ModifiedFaith = Faith+ value;
                    break;
                case "YIELD_CULTURE":
                    ModifiedCulture = Culture + value;
                    break;
                case "YIELD_SCIENCE":
                    ModifiedScience = Science + value;
                    break;
            }
        }

        public string BaseYieldString
        {
            get
            {
                string yield = "Food:  " + Food.ToString() + "  |  Gold:  " + Gold.ToString() +  "  |  Production:  " + Production.ToString()  +"  |  Faith:  " + Faith.ToString() +  "  |  Culture:  " + Culture.ToString() + "  |  Science:  " + Science.ToString() + " ";
                return yield.Replace(" 0 ", " - ");
            }
        }

        public string ModifiedYieldString
        {
            get
            {
                string yield = "Food:  " + ModifiedFood.ToString() + "  |  Gold:  " + ModifiedGold.ToString() + "  |  Production:  " + ModifiedProduction.ToString() + "  |  Faith:  " + ModifiedFaith.ToString() + "  |  Culture:  " + ModifiedCulture.ToString() + "  |  Science:  " + ModifiedScience.ToString() + " ";
                return yield.Replace(" 0 ", " - ");
            }
        }

        public string YieldChangesString
        {
            get
            {
                string yield = "";
                if (ModifiedFood != 0) yield += "Food: +" + (ModifiedFood - Food).ToString() + " | ";
                if (ModifiedGold != 0) yield += "Gold: +" + (ModifiedGold - Gold).ToString() + " | ";
                if (ModifiedProduction != 0) yield += "Production: +" + (ModifiedProduction - Production).ToString() + " | ";
                if (ModifiedFaith != 0) yield += "Faith: +" + (ModifiedFaith - Faith).ToString() + " | ";
                if (ModifiedCulture != 0) yield += "Culture: +" + (ModifiedCulture - Culture).ToString() + " | ";
                if (ModifiedScience != 0) yield += "Science: +" + (ModifiedScience - Science).ToString() + " | ";
                return (yield.Length > 3) ? yield.Substring(0, yield.Length - 3) : yield;
            }
        }


    }
}
