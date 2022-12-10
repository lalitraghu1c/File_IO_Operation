using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FileIOOperation.JSONSerialization;

namespace FileIOOperation
{
    public class JSONSerialization
    {
        public static void JsonDeSerialization()
        {
            string json = @"{
                'Name' : 'Lalit',
                'Description' : 'Welcome to Coding Bootcamp'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine("Name = {0} \nDescription = {1}",bsObj.Name,bsObj.Description);
        }
        public static void JsonSerialization()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Lalit",
                Description = "Welcome to Coding Bootcamp"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
        public class BlogSites
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}