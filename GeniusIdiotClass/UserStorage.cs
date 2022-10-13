using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniusIdiotClass
{
    public class UserStorage
    {
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/result.json";
        
        public static void SaveUserResults(List<User> userList)
        {
            var text = JsonConvert.SerializeObject(userList);
            FileSystem.EraseData(file);
            FileSystem.AppendToFile(file, text);
        }

        public static List<User> GetUsersResults()
        {
            return FileSystem.ReadResults(file);
        }
    }
}
