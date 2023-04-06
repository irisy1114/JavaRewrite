using System;
using System.Collections.Generic;
using System.IO;

namespace JavaRewrite
{
    public class DataContext
    {
        private string _fileName { get; set; }
        public DataContext(string fileName)
        {
            _fileName = fileName;      
        }
        public void ReadFromFile()
        {
            try
            {
                using (var reader = new StreamReader(_fileName))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    //while (reader.Peek() >= 0)
                    {
                        //Console.WriteLine(reader.ReadLine());
                        Console.WriteLine(line);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
        }
        public void WriteToFile(List<string> lines)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_fileName))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
        }
    }
}
