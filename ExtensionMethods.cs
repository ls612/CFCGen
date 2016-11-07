using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    public static class ExtensionMethods
    {

        public static string ToTitleCase(this string input)
        {
            input = input.Replace('_', ' ');
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }


        /// <summary>
        /// Extension method for a string that removes variants of line breaks.
        /// </summary>
        public static string ReplaceLineBreak(this string value, string replacement)
        {
            if (String.IsNullOrEmpty(value))
            {
                return "";
            }
            string lineSeparator = ((char)0x2028).ToString();
            string paragraphSeparator = ((char)0x2029).ToString();

            return value.Replace("\r\n", replacement).Replace("\r", replacement).Replace("\n", replacement).Replace(lineSeparator, replacement).Replace(paragraphSeparator, replacement);
        }



        public static List<PropertyInfo> GetDbSetProperties(this DbContext context)
        {
            var dbSetProperties = new List<PropertyInfo>();
            var properties = context.GetType().GetProperties();

            foreach (var property in properties)
            {
                var setType = property.PropertyType;

                /*
                #if EF5 || EF6
                            var isDbSet = setType.IsGenericType && (typeof (IDbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()) || setType.GetInterface(typeof (IDbSet<>).FullName) != null);
                #elif EF7
                            var isDbSet = setType.IsGenericType && (typeof (DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()));
                #endif
                */
                var isDbSet = setType.IsGenericType && (typeof(DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()));
                if (isDbSet)
                {
                    dbSetProperties.Add(property);
                }
            }

            return dbSetProperties;

        }
    }
}
