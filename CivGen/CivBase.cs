using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{

    public enum HeaderType
    {
        h1,
        h2,
        h3,
    }

    /// <summary>
    /// Base class for Civ Classes.
    /// </summary>
    public abstract class CivBase
    {
        private const string BaseURL = @"www.civfanatics.com\WarAcademy\Civ6\";

        public virtual string URL
        {
            get
            {
                return BaseURL + this.GetType().BaseType.Name + @"\";
            }
        }


        /// <summary>
        /// This must be implemented in the derived class.  It must point to whichever field / property is going to 
        /// be used as the Reference Name.  Eg. for 'Buildings' it is simply 'Name' (although corrected such that
        /// 'LOC_BUILDING_MONUMENT_NAME' returns 'MONUMENT', but for Boosts it might be 'TriggerDescription')
        /// </summary>
        public abstract string RefName { get; }


        /// <summary>
        /// Returns html that used in other properties to set the anchor for this instance.
        /// </summary>
        private string Anchor
        {
            get
            {
                return "id=\"" + RefName + "\"";
            }
        }

        /// <summary>
        /// Returns the full html that can be embedded to create an anchor pointing to the appropriate location. 
        /// </summary>
        /// <param name="headerType">html header type.</param>
        /// <returns></returns>
        public virtual string AnchoredHeaderMarkup(HeaderType headerType)
        {
            return "<" + headerType.ToString() + " " + Anchor + ">" + RefName + "</" + headerType.ToString() + ">";
        }

        /// <summary>
        /// Returns the full url of the anchor that can be used as a reference from a different page / class.
        /// </summary>
        public virtual string GetAnchorURL
        {
            get
            {
                return URL + "#" + RefName;
            }
        }
    }
}
