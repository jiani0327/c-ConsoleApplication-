using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest
{
    class ObjectOrientedProgrammingCourse
    {
        public String studentName;
        public String studentid;
        public String identificationCard;
        public float marks;

        public void SetStudentDetails(String studentname, String studentid, String identificationcard, float marks)
        {
            List<string> studentDetails = new List<string>();
            studentDetails.Add(studentname);
            studentDetails.Add(studentid);
            studentDetails.Add(identificationcard);
        }
    }
}
  class student : ObjectOrientedProgrammingCourse
{
    public String studentname { get;set;}
    public String studentid { get;set;}
    public String identificationcard { get;set;}
    public float marks { get;set;}


    public static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>()
    {
     new Student() { studentiD = 001, studentName = "Ali", identificationcard = "020405-13-0012", marks = 65.5  } ,
     new Student() { studentiD = 002, studentName = "Steve",identificationcard = "010203-13-0013", marks = 76  } ,
     new Student() { studentiD = 003, studentName = "Marry",identificationcard = "040506-13-0014", marks = 88  } ,
     new Student() { studentiD = 004, studentName = "Riky" , identificationcard ="010406-13-0015", marks = 96  } ,
     new Student() { studentiD = 005, studentName = "Gary" , identificationcard = "010206-13-0045", marks = 56  }
     };
        List<String> studentList2 = new List<String>() { "Ali", "Steve", "Marry", "Riky", "Gary" };

        var result = student.OrderByAscending(str => str);
        Console.WriteLine("Sorted list in Ascending order:");
        foreach (string stud in result)
        {
            Console.Write(stud + " ");
        }
        Console.WriteLine();

        String[] arr = new String[] { "020405 - 13 - 0012", "010203 - 13 - 0013", "040506 - 13 - 0014", "010406 - 13 - 0015", "010206 - 13 - 0045" };

        arr = arr.OrderByDescending(c => c).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            string value = arr[i];
            Console.Write(value + " ");
        }
    }
    
}



