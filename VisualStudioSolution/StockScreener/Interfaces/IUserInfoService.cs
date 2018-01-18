﻿
using System.Collections.Generic;
using System.Windows;

namespace StockScreener.Interfaces
{
    public interface IUserInfoService
    {
        IUser LoggedInUser { get; }

        /// <summary>
        /// Log in the user
        /// False if log in fails
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool LogInUser(string user);

        /// <summary>
        /// Remove the logged in user reference
        /// </summary>
        void LogOffUser();

        List<IUser> Users { get; }
        /// <summary>
        /// Populate the users from a file
        /// If file does not exist or can't be deserialized it will return false
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        bool LoadUsersFromFile(string filePath);

        /// <summary>
        /// Save the User list to file.  Return false on failure
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        bool SaveUsersToFile(string filePath);

    }
}