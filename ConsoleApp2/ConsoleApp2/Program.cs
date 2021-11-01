using System;
using System.IO;
using System.Xml;
using Aspose.Cells;
using Muiv_Xls_Xml;
using Newtonsoft.Json;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetXmlFromXls(@"C:\Users\Win10_Game_OS\OneDrive\Рабочий стол\ffff\fff.xls", @"C:\Users\Win10_Game_OS\OneDrive\Рабочий стол\ffff\ddd.xlsx"));

            Console.WriteLine(GetXmlFromXlsx(@"C:\Users\Win10_Game_OS\OneDrive\Рабочий стол\ffff\ddd.xlsx"));



        
















        }



        static String GetXmlFromXls(String xlsPath, String xlsxPath) {

            XlsxToXml convertXML = new XlsxToXml();

            XlsToXlsx convertXlsx = new XlsToXlsx();

            convertXlsx.ConvertToXlsxFile(xlsPath, xlsxPath);

            string exelSTR = convertXML.ConvertByFile(xlsxPath);


        return exelSTR;


        }




        static String GetXmlFromXlsx(String xlsxPath) {



            XlsxToXml convertXML = new XlsxToXml();

            string exelSTR = convertXML.ConvertByFile(xlsxPath);


            return exelSTR;
        }






            }














            






        }



      








    
