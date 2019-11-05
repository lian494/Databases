using System.IO;

namespace Databases
{
    class FileReader
    {
        private string _text;
        private string _url;

        public FileReader(string url)
        {
            _url = url;
            if(File.Exists(url))
                _text = File.ReadAllText(url);
            else
            File.Create(url);
        }

        public void WriteName(string name,int age)
        {
            using(StreamWriter sw=File.AppendText(_url))
            {
                sw.Write(name);
                sw.Write(" ");
                sw.Write(age);
                sw.WriteLine("y");
            }

        }
    }
}