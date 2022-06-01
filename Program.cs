  using System;
  using System.IO;

namespace Working_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var path = @"c:\somefile.jpg";
          File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile\myfile.jpg,", true);
           File.Delete (path);
            if (File.Exists (path))
               {
              //
               }
           var content =  File.ReadAllText(path);

            var fileInfo = new FileInfo (path);
           fileInfo.CopyTo("...");
           fileInfo.Delete();
           if (fileInfo.Exists)
            {
                //
            }
     
            Directory.CreateDirectory (@"C:\Users\guill\source\repos");
            var files =  Directory.GetFiles (@"C:\Users\guill\source\repos", "*.sln", SearchOption.AllDirectories);

            foreach (var file in files)
            Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\guill\source\repos", "*.sln", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
        }
    }
}
