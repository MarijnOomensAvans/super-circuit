using System;
using System.IO;

namespace View
{
    internal class FileReader
    {
        public FileReader()
        {
        }

        internal string[] ReadFile(string name)
        {
            var _filePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(_filePath).FullName;
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\Circuits\" + name + ".txt";

            string[] lines = File.ReadAllLines(_filePath);
            return lines;
        }
    }
}