using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Models;

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
            catch (Exception)
            {
             
            }
                      
                return listOfFeedDeserialized;
            
        }

        public List<Episode> getEpisodes(string url)
        {
            XmlReader rssReader = XmlReader.Create(url);
            SyndicationFeed rssFeed = SyndicationFeed.Load(rssReader);
            List<Episode> allEpisodes = new List<Episode>();
            foreach (var item in rssFeed.Items)
            {
                Episode episode = new Episode(item.Title.Text);
                episode.Description = item.Summary.Text;
                allEpisodes.Add(episode);
            }
            return allEpisodes;
        }

        public int GetIndexOfCategory(string name)
        {
            int i = 0;
            foreach (var feed in listOfFeeds)
            {
                if (name.Equals(feed.Category))
                {
                    break;
                }
                i++;
            }
            return i;
        }

        public int GetIndexOfName(string name)
        {
            throw new NotImplementedException();
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
