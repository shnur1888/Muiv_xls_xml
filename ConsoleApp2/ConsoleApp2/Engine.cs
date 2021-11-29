using System;
using System.IO;
using System.Xml;
using Aspose.Cells;
using Muiv_Xls_Xml;
using Newtonsoft.Json;



namespace ConsoleApp2
{
    class engine
    {
        static void Main(string[] args)
        {



            String[] dirs = GetDirs.GetAllDirs(@"C:\Users\Win10_Game_OS\OneDrive\Рабочий стол\ffff");



            for (int i = 0; i < dirs.Length; i++)
                Console.WriteLine(dirs[i]);














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



      








    
