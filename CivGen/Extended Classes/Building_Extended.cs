using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    
    public partial class Building : CivBase
    {
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



    }
   
}
