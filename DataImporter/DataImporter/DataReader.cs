using DataImporter.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter
{
    public class DataReader
    {
        public List<News> Read(string path)
        {
            List<News> result = new List<News>();

            string text = File.ReadAllText(path);
            result = JsonConvert.DeserializeObject<List<News>>(text);
            return result;
        }
    }
}
