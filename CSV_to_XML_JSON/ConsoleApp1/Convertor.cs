using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Convertor
    {
        public void WriteXML(List<Hotel> hotels, string fileName)
        {
            var ser = new XmlSerializer(typeof(List<Hotel>));

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                ser.Serialize(fs, hotels);
            }
        }

        public void WriteJSON(List<Hotel> hotels, string fileName)
        {
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(hotels);

            File.WriteAllText(fileName, json);
        }
    }
}
