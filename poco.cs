using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using LumenWorks.Framework.IO.Csv;
namespace openCsv
{
    /// <summary>
    /// create object structure 
    /// </summary>
    public class poco
    {
        //attributs
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Country { get; set; }
        //default constructor
        public poco()
        {

        }
        //parameteriseed constructor
        public poco(string name, string email, long phone, string country)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Country = country;
        }

    }
    public class pocoCsvToBean
    {
        public void pocoMethod()
        {
            try
            {
                //read the csv file by using csv reader
                //streamReader read the text from file
                //csv reader read the csv file
                using StreamReader read = new StreamReader(@"D:\trimbak\openCsv\user.text.txt");
                using CsvReader CSV = new CsvReader(read, true);
                //getting number of fields or record from file
                int fieldCount = CSV.FieldCount;
                //getting field header in string array 
                string[] header = CSV.GetFieldHeaders();
                List<poco> data = new List<poco>();
                while (CSV.ReadNextRecord())
                {
                    poco objectOfPoco = new poco(CSV[0], CSV[1], long.Parse(CSV[2]), CSV[3]);
                    data.Add(objectOfPoco);
                }
                foreach (poco Record in data)
                {
                    Console.WriteLine($"Name : {Record.Name}");
                    Console.WriteLine($"Email : {Record.Email}");
                    Console.WriteLine($"Number : {Record.Phone}");
                    Console.WriteLine($"Country : {Record.Country}");
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
