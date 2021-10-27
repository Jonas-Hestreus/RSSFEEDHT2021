using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System;
using Models;
namespace DAL
{
    public class DataManager
    {
        public void SerializeFiles(List<Feed> listofFeeds)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));
            using (FileStream reader = new FileStream("feeds.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(reader, listofFeeds);
            }
        }
        public List<Feed> DerializeFiles()
        {
            List<Feed> itemsInXML;
            XmlSerializer serilizer = new XmlSerializer(typeof(List<Feed>));

            using (Stream reader = new FileStream("feeds.xml", FileMode.Open, FileAccess.Read))
            {
                itemsInXML = (List<Feed>)serilizer.Deserialize(reader);
            }

            return itemsInXML;
        }
    }
}
