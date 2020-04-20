using System;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;
namespace openCsv
{
    class csv
    {
        static void Main(string[] args)
        {
            //create object of read csv file and call readfile method
            ReadCsvFile read = new ReadCsvFile();
            read.ReadFile();
            //create object of writer csv file and call write method
            writer write = new writer();
            write.WriteMetode();
        }
    }
}
