using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        //create 10 student with unique id and name
        static List<Student> GetStudentData()=>
            Enumerable.Range(1,10).Select(i => new Student
            {
                Id=i,
                Name=$"Student-{i}"
            }).ToList();

        static async Task<int> ProcessStudentAsync(Student student) 
            // waiting for 100 ms and do student id * 2 
            //and return Task (Thread) taht returns an integer
        {
            await Task.Delay(100);
            Console.WriteLine($"Processing data for {student.Name}");
            return student.Id * 2;
        }

        static async Task Main() // Task Main method
        {
            var students=GetStudentData(); //Generate 10 students and get the data inside var students
            //wait for all student Id's multiplied by 2 with delay 100 ms
            var results=await Task.WhenAll(students.Select(st => ProcessStudentAsync(st)));
            //sum of student id's after multiplying with 2
            Console.WriteLine($"Total processed data: {results.Sum()}");
        }

    }
}
