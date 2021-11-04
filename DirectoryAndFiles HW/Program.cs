using System;
using System.IO;
using System.Linq;

namespace DirectoryAndFiles_HW
{
    public class Program
    {

        static void Main(string[] args)
        {
            //string[] folders = System.IO.Directory.GetDirectories(@"C:\", "*", System.IO.SearchOption.TopDirectoryOnly);
            //for (int i = 0; i < folders.Length; i++)
            //{
            //    Console.WriteLine(folders[i]);
            //}

            //File.Create("D:\\ DanielTest\\a.csv");
            //foreach (var drive in drives)
            //{
            //    Console.WriteLine(drive);
            //}
            var drives = Directory.GetLogicalDrives();
           
            var topDirectories = Directory.GetDirectories(drives[0]);
            foreach (var dir in topDirectories.Take(10))
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("=============================================");

            printGreatest3Files(@"c:\");
            Console.WriteLine("=============================================");
            Student.StudentToJason();
            Console.WriteLine("=============================================");
            var a = Student.StudentFixedL();
            Console.WriteLine(a);
            Console.WriteLine("=============================================");
            Student.StudentCsvL();
            Console.WriteLine("=============================================");
            Student.ReadStudentListFromScv();

            #region ex 7 + ex 8 + ex9
            // ex 7 = fixed length
            // ex 8  = הוא מגביל אותך
            // ex 9 = קובץ טקסט רגיל יכול להכיל רק אותיות ומספרים בקוד האסקי וקובץ בינארי יכול להכיל את כל התווים האפשרים

            #endregion
        }
        public static void printGreatest3Files(string dir)
        {
            var di = new DirectoryInfo(dir);
            var result = di.GetFiles().OrderByDescending(file => file.Length).Take(3).ToList();
            foreach (var fileInfo in result)
            {
                Console.WriteLine(fileInfo.Name + "last updated: " + fileInfo.LastWriteTime);
            }
        }

    }
    
}
