﻿using System.Windows;
using StockScreener.Interfaces;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace StockScreener.Model
{
    /// <summary>
    /// Implementation of a user info service
    /// Manages lists of users and logging in/ouot
    /// </summary>
    public class UserInfoService : Notifyable, IUserInfoService
    {

        private IUser _loggedInUser;
        /// <summary>
        /// Reference to the logged in user
        /// </summary>
        public IUser LoggedInUser
        {
            get { return _loggedInUser; }
            private set
            {
                _loggedInUser = value;
                RaisePropertyChanged();
            }
        }

        private List<IUser> _users;
        /// <summary>
        /// All available users
        /// </summary>
        public List<IUser> Users
        {
            get { return _users; }
            private set
            {
                _users = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Populate the list of users from a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool LoadUsersFromFile(string filePath)
        {
            //todo
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Log a user in if they exist in the list of users
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool LogInUser(string userName)
        {
            //TESTING for now just fill with something
            if (userName.ToLower() == "test")
            {
                LoggedInUser = new User("Test");
                return true;
            }
            else
            {
                MessageBox.Show("BAD USER NAME: TESTING: MUST ENTER USERNAME OF \"TEST\"");
                return false;
            }
            ////eventually should do below to only login if we have it
            ////Do we have a user that matches the username
            ////Make lowercase to ignore casing
            //if(Users.Any(x=>x.Name.ToLower() == userName.ToLower()))
            //{
            //    //Set the logged in user = to the first item in the list with the same name
            //    LoggedInUser = Users.FirstOrDefault(x => x.Name.ToLower() == userName.ToLower());
            //    return true;
            //}
            //return false;

            //////THIS IS JUST TESTING ON HOW TO GET A STOCK VALUE.  WANTED TO DO IN A PLACE I KNEW WOULD GET CALLED
            ////using (var httpClient = new WebClient())
            ////{

            ////    var json = httpClient.DownloadString("https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=15min&outputsize=full&apikey=demo");

            ////    // Now parse with JSON.Net
            ////}

            //return true;
        }


        public bool SaveUsersToFile(string filePath)
        {
            //TODO
            throw new System.NotImplementedException();
        }

        public void LogOffUser()
        {
            LoggedInUser = null;
        }
    }
}