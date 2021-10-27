using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using Models;
namespace DAL
{
    public class DatamanagerCategory
    {
        public void SerializeFiles(List<Category> listofCategory)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream reader = new FileStream("category.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(reader, listofCategory);
            }
        }
        public List<Category> DerializeFiles()
        {

            List<Category> itemsInXML;
            XmlSerializer serilizer = new XmlSerializer(typeof(List<Category>));
            using (FileStream reader = new FileStream("category.xml", FileMode.Open, FileAccess.Read))
            {
                itemsInXML = (List<Category>)serilizer.Deserialize(reader);
            }

            return itemsInXML;


        }
    }
}
