using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MyLibs.Serialisation
{
    public class Serializer
    {
        public void Serialize<T>(T data, string parth)
        {
            using (StreamWriter file = new StreamWriter(parth, true))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file.BaseStream, data);
            }
        }
        public T Deserialize<T>(string parth)
        {
            using (StreamWriter file = new StreamWriter(parth, true))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(file.BaseStream);
            }
        }
    }
}
