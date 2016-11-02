using System;
using System.Collections.Generic;
using System.Globalization;
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
        private const string BaseURL = @"http://www.civfanatics.com/Civ6/";

        public virtual string URL
        {
            get
            {
                return BaseURL + this.GetType().BaseType.Name + @"/";
            }
        }

        public virtual string OpenURL
        {
            get
            {
                return BaseURL + this.GetType().BaseType.Name;
            }
        }

        /// <summary>
        /// This must be implemented in the derived class.  It must point to whichever field / property is going to 
        /// be used as the Reference Name.  Eg. for 'Buildings' it is simply 'Name' (although corrected such that
        /// 'LOC_BUILDING_MONUMENT_NAME' returns 'MONUMENT', but for Boosts it might be 'TriggerDescription')
        /// </summary>
        public abstract string ReferenceName { get; }


        public virtual string FriendlyName
        {
            get
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                return textInfo.ToTitleCase(ReferenceName.Replace('_', ' ').ToLower());
            }
        }

        /// <summary>
        /// Returns html that used in other properties to set the anchor for this instance.
        /// </summary>
        private string Anchor
        {
            get
            {
                return "id=\"" + ReferenceName + "\"";
            }
        }

        /// <summary>
        /// Returns the full html that can be embedded to create an anchor pointing to the appropriate location. 
        /// </summary>
        /// <param name="headerType">html header type.</param>
        /// <returns></returns>
        public virtual string html_Header_With_Anchor(HeaderType headerType)
        {
            return "<" + headerType.ToString() + " " + Anchor + ">" + FriendlyName + "</" + headerType.ToString() + ">";
        }
                     

        /// <summary>
        /// Returns the full url of the anchor that can be used as a reference from a different page / class.
        /// Uses the default page name (the name of the class)
        /// </summary>
        public virtual string html_AnchorURL()
        {
                return OpenURL + "#" + ReferenceName;
        }


        /// <summary>
        /// Returns the full url of the anchor that can be used as a reference from a different page / class.
        /// Allows a custom page name to be used.
        /// </summary>
        public virtual string html_AnchorURL(string pageName)
        {
            return BaseURL + pageName + "#" + ReferenceName;
        }

        /// <summary>
        /// Returns the URL that is used by another class to reference this URL and anchor point.
        /// </summary>
        public virtual string html_Goto_URL_Link
        {
            get
            {
                return "<a href=" + html_AnchorURL() + ">" + FriendlyName + "</a>";
            }
        }

        /// <summary>
        /// Returns the URL that is used by another class to reference this URL and anchor point.
        /// </summary>
        public virtual string html_Goto_URL_Link_Same_Page
        {
            get
            {
                return "<a href=\"#" + ReferenceName +   "\">" + FriendlyName + "</a>";
            }
        }

        //http://www.civfanatics.com/civ6/wonders/#PETRA
    }
}
