using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using DAL;

namespace BL.Controllers
{
    public class FeedController
    {
        Validering validator;
        IFeedRepositroy<Feed> feedRepository;
        public FeedController()
        {
            validator = new Validering();
            feedRepository = new FeedRepository();
        }

        public List<Feed> getAllFeeds()
        {
            List<Feed> feedList = feedRepository.GetAll();
            return feedList;
        }



        public void Createfeed(string pName, string pUrl, string pCategory, string fReq)
        {
            if (validator.TextEmpty(pUrl))
            {
                List<Episode> episodes = feedRepository.getEpisodes(pUrl);
                Feed newFeed = new Feed(pName, pUrl, pCategory, episodes, fReq);
                feedRepository.Create(newFeed);
            }
        }

        public void deleteFeedasedOnCategory(string category)
        {
            List<Feed> listFeed = feedRepository.GetAll();
            int i = feedRepository.GetIndexOfCategory(category);
            feedRepository.Delete(i);

        }
    }
}
