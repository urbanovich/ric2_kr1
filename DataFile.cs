using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ric2_kr_1
{
    public class DataFile
    {
        public static string FilePath = "./data.dat";
        
        public static void Write(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);

            File.WriteAllBytes(DataFile.FilePath, bytes);
        }

        public static string Read()
        {
            byte[] bytes = File.ReadAllBytes(DataFile.FilePath);

            return Encoding.UTF8.GetString(bytes);
        }
    }
}