using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{

    public enum eERA
    {
        ANCIENT,
        CLASSICAL,
        MEDIEVAL,
        RENAISSANCE,
        INDUSTRIAL,
        MODERN,
        ATOMIC,
        INFORMATION,
    }

   


    public partial class Era : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_ERA_";
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

        public eERA ERA
        {
            get { return (eERA)Enum.Parse(typeof(eERA), ReferenceName, true); }
        }

        public override eERA ReferenceEra
        {
            get
            {
                return ERA ;
            }
        }
    }
}
