using System;
using System.Collections.Generic;
using System.Text;

namespace Muiv_Xls_Xml
{
    public class GetDirs
    {
        public static String[] GetAllDirs(String dirPath)
        {




            string[] files = System.IO.Directory.GetFiles(dirPath);

            return files;

        }







    }

}
