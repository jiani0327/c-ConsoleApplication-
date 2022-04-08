using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
     class studentdetails
    {
      student stduentName = new student("Ali", "Steve", "Marry", "Riky", "Gary");
      student identificationcard = new student("020405 - 13 - 0012", "010203 - 13 - 0013", "040506 - 13 - 0014", "010406 - 13 - 0015", "010206 - 13 - 0045")

      public void DisplayAllStudentDetails()
        {
            Console.WriteLine(studentName);
            Console.WriteLine(identificationcard);
        }
    }
}
