using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert64
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoApp = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string caminhoGif = caminhoApp + @"Resorce\homer.gif"; 

            string image64 = ConverterParaBase64(caminhoGif);
            Console.WriteLine(image64);
        }

        public static string ConverterParaBase64(string path)
        {

            string base64String = Convert.ToBase64String(File.ReadAllBytes(path));

            return "data:image/gif;base64," + base64String;
        }
    }
}
