using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class XlsToXlsx
    {

        public void ConvertToXlsxFile(string xlsPath, string xlsxPath)
        {


           
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(xlsPath);
            workbook.SaveToFile(xlsxPath, ExcelVersion.Version2013);



        }


    }
}
