using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
using Models;
using DAL.Exceptions;
namespace DAL
{
    public class DataManager
    {
        public void SerializeFiles(List<Feed> listofFeeds)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream reader = new FileStream("feeds.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(reader, listofFeeds);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("feeds.xml", "Could not serialize the file");
            }
        }
        public List<Feed> DerializeFiles()
        {
            try
            {
                List<Feed> itemsInXML;
                XmlSerializer serilizer = new XmlSerializer(typeof(List<Feed>));

                using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
                {
                    itemsInXML = (List<Feed>)serilizer.Deserialize(reader);
                }
                return itemsInXML;
            }
            catch (Exception)
            {
                throw new SerializerException("feeds.xml", "Could not deserialize the file.");
            }
        }
    }
}
