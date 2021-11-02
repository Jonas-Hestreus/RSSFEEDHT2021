        using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Models;
using DAL.Exceptions;
using DAL;

namespace DAL.Repositories
{
   public class FeedRepository : IFeedRepositroy<Feed>
    {
        DataManager dataManager;
        List<Feed> listOfFeeds;

            public FeedRepository()
        {
            dataManager = new DataManager();
            listOfFeeds = new List<Feed>();
            listOfFeeds = GetAll();
        }
        public void Create(Feed podcast)
        {
            listOfFeeds.Add(podcast);
            SaveChanges();
        }

        public void Delete(int i)
        {
            listOfFeeds.RemoveAt(i);
            SaveChanges();
        }

        public List<Feed> GetAll()
        {
            List<Feed> listOfFeedDeserialized = new List<Feed>();
            try
            {
                listOfFeedDeserialized = dataManager.DerializeFiles();

            }
            catch (SerializerException)
            {
                Console.WriteLine("Could not deserialize file feeds.xml");
            }
                      
                return listOfFeedDeserialized;
            
        }

        public async Task <List<Episode>> getEpisodes(string url)
        {
            XmlReader rssReader = XmlReader.Create(url);
            SyndicationFeed rssFeed = await Task.Run(() => SyndicationFeed.Load(rssReader));
            List<Episode> allEpisodes = new List<Episode>();
            foreach (var item in rssFeed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                episode.Description = item.Summary.Text;
                allEpisodes.Add(episode);
            }
            return allEpisodes;
        }

        public int GetIndexOfCategory(string categoryName)
        {
            return GetAll().FindIndex(e => e.Category.Equals(categoryName));
        }

        public int GetIndexOfName(string name)
        {
            return GetAll().FindIndex(e => e.Name.Equals(name));
        }

            public void SaveChanges()
        {
             dataManager.SerializeFiles(listOfFeeds);
        }

        public void Update(int i, Feed newMedia)
        {
            if(i >= 0)
            {
                listOfFeeds[i] = newMedia;
            }
            SaveChanges();
        }
        
    }
}
