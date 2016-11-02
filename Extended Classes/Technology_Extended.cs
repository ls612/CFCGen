using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Technology: CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_TECH_";
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


        public string GenerateHTML()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(html_Header_With_Anchor(HeaderType.h2));

            //Cost
            output.AppendLine("\t" + "Cost:\t" + Cost.ToString());

            //Pre-Requisites
            string prereqtechs ="";
            foreach (Technology prereq in this.Technologies)
            {
                prereqtechs += prereq.html_Goto_URL_Link + "|";
            }
            output.AppendLine("\t" + "PreRequisites:\t" + prereqtechs);

            return output.ToString();
        }

    }
}
