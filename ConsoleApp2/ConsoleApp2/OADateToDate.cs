using System;
using System.Collections.Generic;
using System.Text;

namespace Muiv_Xls_Xml
{
    public class OADateToDate
    {



       public static String ToDate(String OADate)
        {
            DateTime date;
            date = DateTime.FromOADate(Double.Parse(OADate));
            String Result = date.ToString("d") ;









            return Result;

        }






    }
}
