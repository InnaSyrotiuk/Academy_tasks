using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputFilePath = @"D:\workspace\Academy tasks\CSV_to_XML_JSON\Hotels.txt";
            //string outputFilePathXML = @"D:\workspace\Academy tasks\CSV_to_XML_JSON\Hotels.xml";
            //string outputFilePathJSON = @"D:\workspace\Academy tasks\CSV_to_XML_JSON\Hotels.json";
            string inputFilePath = ConfigurationManager.AppSettings["InputFile"];
            string outputFilePathXML = ConfigurationManager.AppSettings["outputFilePathXML"];
            string outputFilePathJSON = ConfigurationManager.AppSettings["outputFilePathJSON"];


            HotelParser parser = new HotelParser();
            List<Hotel> hotels = parser.ReadAll(inputFilePath).OrderBy(x=>x.Rating).ToList();
            
           

            var convertor = new Convertor();
            Console.WriteLine("Please write 1 if you want to save data in JSON, or 0 for XML");
            string result = Console.ReadLine();
            if (result == "1")
            {
                convertor.WriteJSON(hotels, outputFilePathJSON);
            }
            else if (result == "0")
            {
                convertor.WriteXML(hotels, outputFilePathXML);
            }
        }

    }
}
