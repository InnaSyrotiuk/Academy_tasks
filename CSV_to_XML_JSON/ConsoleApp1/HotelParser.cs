using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HotelParser
    {
        public List<Hotel> ReadAll(string path)
        {
            List<Hotel> result = new List<Hotel>();
            string[] lines = File.ReadAllLines(path);

            if (lines.Length > 1)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    Hotel hotel = new Hotel();
                    hotel.Name = values[0];
                    hotel.HotelId = Convert.ToInt32(values[1]);
                    hotel.FoundedDate = ConvertToDate(values[2]);
                    hotel.Capacity = Convert.ToInt32(values[3]);
                    if (values[4] != "")
                    {
                        hotel.Rating = Convert.ToDouble(values[4].Replace('.', ','));
                    } else
                    {
                        hotel.Rating = 0;
                    }
                    result.Add(hotel);
                }

            }

            return result;
        }
        public DateTime ConvertToDate(string date)
        {
            string[] values = date.Split('/');
            int day = Convert.ToInt32(values[1]);
            int month = Convert.ToInt32(values[0]);
            int year = Convert.ToInt32(values[2]);

            return new DateTime(year, month, day);
        }
        
       
    }
}
