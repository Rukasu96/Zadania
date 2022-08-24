using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lekcja7
{
    [Serializable]//tylko do binarnego
    public class Settings
    {
        private int id = 15;
        private int sound;
        private double brightness;
        private string resolution;

        public int Sound { get => sound; set => sound = value; }
        public double Brightness { get => brightness; set => brightness = value; }
        public string Resolution { get => resolution; set => resolution = value; }

        public void SerializeXML(string filename)
        {
            using(StreamWriter sw = new StreamWriter(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                xml.Serialize(sw, this);
            }
        }

        public static Settings DeserializeXML(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                return xml.Deserialize(sr) as Settings;
            }
        }

        public void SerializeBinary(string filename)
        {
            using(FileStream fs = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
        }

        public static Settings DeserializeBinary(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(fs) as Settings;
            }
        }
    }
}
