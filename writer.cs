using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace openCsv
{
    class writer
    {/// <summary>
    /// write the recordd in file
    /// </summary>
        public void WriteMetode()
        {
            //create list of poco class
            List<poco> Record = new List<poco>()
            {
                //add object in list
                new poco {Name="suraj",Email="trimbakeshwar.1994@gmail.com",Phone=9607610044,Country="india"},
                new poco {Name="dhirraj",Email="dhiraj.1997@gmail.com",Phone=8149713160,Country="india"},
            };
            try 
            {
                using CsvWriter csvWriter = new CsvWriter(new StreamWriter(@"D:\trimbak\openCsv\userWrite.txt", true), System.Globalization.CultureInfo.InvariantCulture);
                {
                    //seprated by ,
                    csvWriter.Configuration.Delimiter = ",";
                    csvWriter.Configuration.HasHeaderRecord = true;
                    csvWriter.Configuration.AutoMap<poco>();
                    csvWriter.WriteHeader<poco>();
                    csvWriter.WriteRecords("\n");
                    //write the list in file
                    csvWriter.WriteRecords(Record);
                    csvWriter.Flush();
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
