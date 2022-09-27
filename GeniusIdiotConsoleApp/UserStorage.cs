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
            using (FileStream fs = new FileStream(file, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes($"{user.name};{user.score};{user.diagnose}" + "\n");
                fs.Write(buffer, 0, buffer.Length);
            }
        }

        public static List<User> GetUsersResults()
        {
            List<User> userList = new List<User>();
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                foreach (string i in Encoding.Default.GetString(buffer).Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries))
                {
                    var t = i.Split(';');
                    userList.Add(new User(t[0], Convert.ToInt32(t[1]), t[2]));
                }
            }
            return userList;
        }
    }
}
