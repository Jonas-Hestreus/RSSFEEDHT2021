using System;
using System.Xml.Serialization;

namespace Models
{
    [XmlInclude(typeof(Category))]

    public class Category
    {
        public string CategoryName { get; set; }

        public Category(string cName)
        {
            CategoryName = cName;
        }

        public Category()
        {

        }
    }
}
