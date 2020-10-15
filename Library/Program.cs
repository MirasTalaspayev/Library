using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\tmk01\source\repos\Library\ExcelFiles\Lib_1";
            using (SpreadsheetDocument s = SpreadsheetDocument.Open(path, true))
            {
                s.Close();
            }
            Console.ReadLine();
        }
    }
}
