using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Terrain : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_TERRAIN_";
        private const string NameSuffix = "_NAME";


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
                return eERA.ANCIENT;        //Kind of irrelevant for terrain...
            }
        }


        public string YieldString
        {
            get
            {
                string yield = "Food: x  |  Gold: y  |  Production: z";
                if (Terrain_YieldChanges.Count == 0) return "Food: -  |  Gold: -  |  Production: -"; ;
                foreach (Terrain_YieldChanges change in this.Terrain_YieldChanges)
                {
                    if (change.FriendlyName == "Food") yield = yield.Replace("Food", "<b>Food</b>").Replace("x", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Gold") yield = yield.Replace("Gold", "<b>Gold</b>").Replace("y", "<b>" + change.YieldChange.ToString() + "</b>");
                    if (change.FriendlyName == "Production") yield = yield.Replace("Production", "<b>Production</b>").Replace("z", "<b>" + change.YieldChange.ToString() + "</b>");

                }

                return yield.Replace('x','-').Replace('y','-').Replace('z','-');
            }
        }

        public ICollection<Feature> FeatureAdjacentTerrains { get { return Features; } }
        public ICollection<Feature> FeatureNotAdjacentTerrains { get { return Features1; } }
        public ICollection<Feature> FeatureValidTerrains { get { return Features2; } }

    }
}
