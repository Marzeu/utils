using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace convert64
{
    class ImageToBase64
    {
        string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public string ConverterParaBase64(string path)    
        {

            string base64String = Convert.ToBase64String(File.ReadAllBytes(path));

            return "data:image/gif;base64," + base64String;
        }
    }
}
