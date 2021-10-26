using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    interface IConvertable
    {
        /// <summary>
        /// Convert some data from Stream
        /// </summary>
        string Convert(Stream stream);
        /// <summary>
        /// Convert some data from file
        /// </summary>
        string ConvertByFile(String path);

    }
}
