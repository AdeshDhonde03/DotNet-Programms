using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger1;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\Log\\";
            try
            {
               Log.CheckFileExist(filepath);
                Log.Info("Adesh Dhonde", filepath);
                Log.Debug("Hello", filepath);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, filepath);
            }
           
           
        }
    }
}
