using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using DAL;
using System.Windows.Forms;

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



        public void Createfeed(string pName, string pUrl, string fReq, string pCategory)
        {
            if (validator.TextEmpty(pUrl) && validator.CheckUrl(pUrl))
            {
                if (validator.TextEmpty(pCategory))
                {
                    if (validator.TextEmpty(fReq))
                    {
                        List<Episode> episodes = feedRepository.getEpisodes(pUrl);
                        Feed newFeed = new Feed(pName, pUrl, pCategory, episodes, fReq);
                        feedRepository.Create(newFeed);
                    }else{
                        MessageBox.Show("Du måste välja i en frekvens!");
                         }
                 }else
                {
                    MessageBox.Show("Du måste välja i en kategori!");
                }
            }
            else
            {
                MessageBox.Show("Du måste fylla i en gitlig url");
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
