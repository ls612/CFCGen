﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public partial class Difficulty : CivBase
    {
        //Constants used to correct / convert the 'Name' to the friendly display name.
        private const string NamePrefix = "LOC_DIFFICULTY_";
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
                return eERA.ANCIENT;
            }
        }
    }
}
