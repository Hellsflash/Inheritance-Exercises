using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
  public class StartUp
    {
     public static void Main()
        {
            try
            {
                string[] students = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string[] workers = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                    

                var student =new Student(students[0], students[1], students[2]);
                var worker = new Worker(workers[0],workers[1],decimal.Parse(workers[2]),double.Parse(workers[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
