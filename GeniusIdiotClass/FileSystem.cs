using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniusIdiotClass
{
    public class FileSystem
    {
        public static void AppendToFile(string file, string text)
        {
            using (FileStream fs = new FileStream(file, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
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

        public static void ReadData(List<Questions> questions, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                foreach (string i in Encoding.Default.GetString(buffer).Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var t = i.Split(';');
                    questions.Add(new Questions(t[0], Convert.ToInt32(t[1])));
                }
            }
        }

        public static void EraseData(string file)
        {
            File.Delete(file);
        }

        public static bool Exists(string file)
        {
            return File.Exists(file);
        }
    }
}
