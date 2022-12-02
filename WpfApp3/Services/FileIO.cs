using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.Services
{
    class FileIO
    {
        private readonly string PATH;

        public FileIO(string path)
        {
            PATH = path;
        }
        public BindingList<DateBook> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<DateBook>();
            }
            using(var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<DateBook>>(fileText);
            }
        }

        public void SaveData(object dateBooks)
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(dateBooks);
                writer.Write(output);
            }
        }
    }
}
