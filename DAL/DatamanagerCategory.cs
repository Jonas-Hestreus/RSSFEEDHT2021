using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using Models;
using DAL.Exceptions;

namespace DAL
{
    public class DatamanagerCategory
    {
        public void SerializeFiles(List<Category> listofCategory)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream reader = new FileStream("category.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(reader, listofCategory);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("category.xml", "Could not serialize to the file");
            }
        }
        public List<Category> DerializeFiles()
        {
            try
            {
                List<Category> itemsInXML;
                XmlSerializer serilizer = new XmlSerializer(typeof(List<Category>));
                using (FileStream reader = new FileStream("category.xml", FileMode.Open, FileAccess.Read))
                {
                    itemsInXML = (List<Category>)serilizer.Deserialize(reader);
                }
                return itemsInXML;
            }
            catch (Exception)
            {
                throw new SerializerException("category.xml", "Could not deserialize to the file");
            }
        }
    }
}
