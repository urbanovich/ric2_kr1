using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ric2_kr_1
{
    public class DataFile
    {
        public static string FilePath = @"./.data.dat";
        
        public static void Write(Subscribe obj)
        {

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(DataFile.FilePath, FileMode.Create, FileAccess.Write)) {
                formatter.Serialize(stream, obj);
                stream.Close();
            }
        }

        public static Subscribe Read()
        {
            IFormatter formatter = new BinaryFormatter();
            Subscribe obj = new Subscribe();
            using (Stream stream = new FileStream(DataFile.FilePath, FileMode.Open, FileAccess.Read)) {
                
                if (stream.Length != 0) {
                    obj = (Subscribe)formatter.Deserialize(stream);
                }
                
            }

            return  obj;
        }
    }
}