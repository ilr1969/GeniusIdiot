using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

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

        public static List<User> ReadResults(string file)
        {
            string users;
            if (FileSystem.Exists(file))
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    users = Encoding.Default.GetString(buffer);
                    return JsonConvert.DeserializeObject<List<User>>(users);
                }
            }
            else
            {
                return new List<User>();
            }
        }

        public static List<Questions> ReadData(string file)
        {
            string questions;
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                questions = Encoding.Default.GetString(buffer);
            }
            return JsonConvert.DeserializeObject<List<Questions>>(questions);
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
