using System;
using System.Collections.Generic;

namespace GeniusIdiotClass
{
    public class UserStorage
    {
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/result.txt";
        
        public static void SaveUserResults(User user)
        {
            string text = $"{user.name};{user.score};{ user.diagnose}#";
            FileSystem.AppendToFile(file, text);
        }

        public static List<User> GetUsersResults()
        {
            List<User> userList = new List<User>();
            FileSystem.ReadResults(userList, file);
            return userList;
        }
    }
}
