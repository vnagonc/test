using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = null;
            try
            {
                writer = File.AppendText("D:\\spkOnlTest.txt");
                writer.WriteLine(DateTime.Now.ToString("yy/MM/dd: H:mm:ss"));
            }
            catch (Exception ex)
            {
                StreamWriter writerError = null;
                writerError = File.AppendText("D:\\spkOnlError.txt");
                writerError.WriteLine(DateTime.Now.ToString("yy/MM/dd: H:mm:ss"));
                writerError.Close();
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
