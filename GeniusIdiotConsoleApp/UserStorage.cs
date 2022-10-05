using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniusIdiotConsoleApp
{
    public class UserStorage
    {
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/result.txt";
        public static void SaveUserResults(User user)
        {
            FileSystem.AppendToFile(file, user);
        }

        public static List<User> GetUsersResults()
        {
            List<User> userList = new List<User>();
            FileSystem.ReadResults(userList, file);
            return userList;
        }
    }
}
