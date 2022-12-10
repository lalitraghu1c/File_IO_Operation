using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    public class BinarySerialization
    {
        public static void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Binary1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }
        public static void Deserialization()
        {
            FileStream fileStream = new FileStream(@"D:\Projects-Bridgelabz\File_IO_Operation\FileIOOperation\Binary1.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deserializedSampledemo.Application_Name} --- ApplicationID {deserializedSampledemo.Application_ID}");
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Demo
    {
        public string Application_Name { get; set; } = "Binary Serialize";
        public int Application_ID { get; set; } = 1001;
    }
}