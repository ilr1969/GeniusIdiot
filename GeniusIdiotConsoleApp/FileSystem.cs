using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniusIdiotConsoleApp
{
    public class FileSystem
    {
        public static void AppendToFile(string file, User user)
        {
            using (FileStream fs = new FileStream(file, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes($"{user.name};{user.score};{user.diagnose}#");
                fs.Write(buffer, 0, buffer.Length);
            }
        }

        public static void ReadResults(List<User> userList, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                foreach (string i in Encoding.Default.GetString(buffer).Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var t = i.Split(';');
                    userList.Add(new User(t[0], Convert.ToInt32(t[1]), t[2]));
                }
            }
        }
    }
}
