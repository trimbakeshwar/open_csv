using System;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace openCsv
{
    public class ReadCsvFile
    {
        /// <summary>
        /// read the data from file
        /// </summary>
        public void ReadFile()
        {
            try
            {
                //read the csv file by using csv reader
                //streamReader read the text from file
                //csv reader read the csv file
                using StreamReader read = new StreamReader(@"D:\trimbak\openCsv\user.text.txt");
                using CsvReader csvReader = new CsvReader(read, true);
                //getting number of fields or record from file
                int fieldCount = csvReader.FieldCount;              
                //getting field header in string array 
                string[] headers = csvReader.GetFieldHeaders();
                //create array list 
                List<string[]> record = new List<string[]>();
                //using while loop featching record one by one in temprecord and add in array list
                while (csvReader.ReadNextRecord())
                {
                    string[] tempRecord = new string[fieldCount];
                    csvReader.CopyCurrentRecordTo(tempRecord);
                    record.Add(tempRecord);

                }
                //print record 
                foreach (string[] Record in record)
                {
                    Console.WriteLine(String.Join(" | ", Record));
                }
            }
            //filenot found exception handle in catch block
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //othen exception handle in this block
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
