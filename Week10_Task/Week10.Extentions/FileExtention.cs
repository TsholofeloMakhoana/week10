using System;
using System.IO;
using System.Threading.Tasks;
using Week10.Extentions.GenericLogic;

namespace Week10.Extentions
{
    public static class FileExtention
    {
        private readonly static string path = @"C:\Temp\File\Week10.txt";
        public static void CreateNewDirectory(string name, string phone, string email)
        {
            QueueUsers queueUser = new QueueUsers();
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
            }

            using (StreamWriter streamWriter = File.AppendText(path))
            {
                queueUser.AddUsers(name, phone, email);
                streamWriter.WriteLine(name + "," +email +"," + phone);           
            }           
        }
        public async static Task<string> ReadFileAsync()
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                
                var read = streamReader.ReadToEnd();
                read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);
                var last = users[^1];
                foreach (var item in users)
                {
                    var user = item.Split(',');
                    System.Console.WriteLine(user[0]);
                    System.Console.WriteLine(user[1]);
                    System.Console.WriteLine(user[2]);
                }
                return read;
            }
        }
    }
}
