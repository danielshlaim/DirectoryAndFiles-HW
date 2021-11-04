using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace DirectoryAndFiles_HW
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

      static  List<Student> studentlist = new List<Student>();

        static Student()
        {
            studentlist.Add(new Student{FirstName = "daniel", LastName = "shlaim"});
            studentlist.Add(new Student { FirstName = "avichii", LastName = "Dahan" });
            studentlist.Add(new Student{FirstName = "gil", LastName = "alkobi"});
            studentlist.Add(new Student { FirstName = "maor", LastName = "deri" });           
        }

        public static void StudentToJason()
        {
            var x = JsonSerializer.Serialize(studentlist);
            File.WriteAllText(@"C:\Users\maorx\OneDrive\Desktop\daniel folder\DirectoryAndFiles HW\DirectoryAndFiles HW\x.json", x);
        }

        public  string StudentFixed()
        {
            string s  = string.Format("{0:5} {1:6}",FirstName,LastName);
            return s;
        }
        public static string StudentFixedL()
        {
            string a = "";
            foreach (var item in studentlist)
            {

                a += item.StudentFixed() + Environment.NewLine;
            }
            return a;
        }

        public string StudentScv()
        {
            string v = string.Format("FirstName :{0} LastName :{1}", FirstName, LastName);
            return v;
        }
        public static void StudentCsvL()
        {
            string a = "";
            foreach (var item in studentlist)
            {

                a += item.StudentFixed() + Environment.NewLine;
            }
            File.WriteAllText(@"C:\Users\maorx\OneDrive\Desktop\daniel folder\DirectoryAndFiles HW\DirectoryAndFiles HW\y.Csv", a);
            
        }

        public static void ReadStudentListFromScv()
        {
            var stu = File.ReadAllLines(@"C:\Users\maorx\OneDrive\Desktop\daniel folder\DirectoryAndFiles HW\DirectoryAndFiles HW\y.Csv").ToList();
        }


    }
}
