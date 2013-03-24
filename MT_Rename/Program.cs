using System;
using System.Collections.Generic;
using System.Text;

namespace MT_Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory());
            foreach (var file in files)
            {
                // get the position
                var pos = System.IO.Path.GetFileName(file).IndexOf('-');
                var dirName = System.IO.Path.GetDirectoryName(file);
                var origName = System.IO.Path.GetFileName(file);
                // get string minus the number and dash
                var newName = System.IO.Path.GetFileName(file).Substring(pos + 1);
                var newPathName = System.IO.Path.Combine(dirName, newName);

                Console.Write(origName);
                Console.Write(" -> ");
                Console.WriteLine(newName);

                // Rename
                System.IO.File.Move(file, newPathName);
            }
            Console.WriteLine("\nPress Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
