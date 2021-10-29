﻿using DAL.Repositories;
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

        public async void Createfeed(string pName, string pUrl, string fReq, string pCategory)
        {
            if (validator.TextEmpty(pUrl) && validator.CheckUrl(pUrl))
            {
                if (validator.TextEmpty(pCategory))
                {
                    if (validator.TextEmpty(fReq))
                    {
                        if (validator.TextEmpty(pName))
                        {
                            if (nameIsUnique(pName))
                            {
                                List<Episode> episodes = await feedRepository.getEpisodes(pUrl);
                                Feed newFeed = new Feed(pName, pUrl, pCategory, episodes, fReq);
                                feedRepository.Create(newFeed);
                            }
                            else
                            {
                                MessageBox.Show("Du har redan en feed med namnet : " + pName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Du måste välja i ett namn!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Du måste välja i en frekvens!");
                    }
                }
                else
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

        public List<Episode> getEpisodes(string name)
        {
            int index = feedRepository.GetIndexOfName(name);
            List<Feed> feeds = getAllFeeds();
            return feeds[index].Episodes;

        }

        public void deleteFeed(string name)
        {
            int i = feedRepository.GetIndexOfName(name);
            feedRepository.Delete(i);
        }

        public async void updateFeed(string pName, string pUrl, string fReq, string pCategory, int index)
        {
            if (validator.TextEmpty(pUrl) && validator.CheckUrl(pUrl))
            {
                if (validator.TextEmpty(pCategory))
                {
                    if (validator.TextEmpty(fReq))
                    {
                        if (validator.TextEmpty(pName))
                        {
                                List<Episode> episodes = await feedRepository.getEpisodes(pUrl);
                                Feed newFeed = new Feed(pName, pUrl, pCategory, episodes, fReq);
                                feedRepository.Update(index, newFeed);
                        }
                        else
                        {
                            MessageBox.Show("Du måste välja i ett namn!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Du måste välja i en frekvens!");
                    }
                }
                else
                {
                    MessageBox.Show("Du måste välja i en kategori!");
                }
            }
            else
            {
                MessageBox.Show("Du måste fylla i en gitlig url");
            }
        }
        public int getIndexByNam(string name)
        {
            return feedRepository.GetIndexOfName(name);
        }

        public Boolean nameIsUnique(string name)
        {
            Boolean nomatch = true;
            foreach (var item in getAllFeeds())
            {
                if (item.Name.Equals(name))
                {
                    nomatch = false;
                    break;
                }
            }
            return nomatch;
        }
    }
}

