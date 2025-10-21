using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeJamAndEarlFirstBatch
{
    public class FileManager
    {
        public static void Create()
        {
            _instance = new FileManager();
        }

        public static FileStream GetFile(string filename)
        {
            return File.OpenRead(_instance._filepath + filename);
        }

        public FileManager() 
        {
            //_filepath = "C:\\Users\\wbhen\\OneDrive\\Desktop\\Lewis\\VideoGame Programming 1\\DemoImages\\";
            _filepath = "C:\\Users\\wbhen\\OneDrive\\Desktop\\Lewis\\VideoGame Programming 1\\Demo\\Images\\";
        }

        private static FileManager _instance;
        string _filepath;   
    }
}
