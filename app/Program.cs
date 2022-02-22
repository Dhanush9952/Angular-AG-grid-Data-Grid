using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      //   IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
      //   IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
      //   IList<string> emptyList = new List<string>();

      //   Console.WriteLine("1st Element in intList: {0}", intList.First());
      //   Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

      //   Console.WriteLine("1st Element in strList: {0}", strList.First());

      //   Console.WriteLine("emptyList.First() throws an InvalidOperationException");
      //   Console.WriteLine("-------------------------------------------------------------");
      //   Console.WriteLine(emptyList.First());

      IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
      IList<string> strList = new List<string>() { "one", "Two", "Three", "Four", "Five" };
      IList<string> emptyList = new List<string>();
      IList<int> oneElementList = new List<int>() { 7 };


int minimum = intList.Min();
System.Console.WriteLine("Minimum number is: {0} {1} {2} {3}",minimum,5,12,16,20,21);

      List<int> numbers = new List<int>();
      numbers.Add(12);
      numbers.Add(13);
      numbers.Add(14);
      numbers.Add(15);
      List<string> letters = new List<string>();
      letters.Add("A");
      letters.Add("B");
      letters.Add("C");
      letters.Add("D");

      System.Console.WriteLine("Array-List in C#:");
      System.Console.WriteLine("=================");
      string[] animals = { "cow", "dog", "buffallo", "donkey" };
      List<string> animalsList = new List<string>();
      animalsList.AddRange(animals);
      foreach (string a in animalsList)
        System.Console.WriteLine(a);
      System.Console.WriteLine("=================");

      Console.WriteLine("1st Element in intList: {0}", intList.LastOrDefault());
      Console.WriteLine("1st Even Element in intList: {0}",
                                       intList.FirstOrDefault(i => i % 2 == 0));

      Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

      Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());
      Console.WriteLine("Thank you!");
      System.Console.WriteLine("Completed!!!");
      Console.WriteLine("The only element oneElementList: {0}", oneElementList.Single());

      System.Console.WriteLine("=================");
      //Using Group By query:

      IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
    };
      var groupedResult = from s in studentList
                          group s by s.Age;
      foreach (var ageGroup in groupedResult)
      {
        Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

        foreach (Student s in ageGroup) // Each group has inner collection
          Console.WriteLine("Student Name: {0}", s.StudentName);
      }
      System.Console.WriteLine("=================");
      int value = 1;
      bool isAdult = Convert.ToBoolean(value);
      Console.WriteLine("Bool: " + isAdult.ToString());
      System.Console.WriteLine("Int: " + Convert.ToInt32(isAdult).ToString());
List<Employee1> emp1 = new List<Employee1>() {


            new Employee1() {emp_id = 300, emp_name = "Anu  ",
                                           emp_lang = "C#"},
  
            new Employee1() {emp_id = 301, emp_name = "Mohit",
                                              emp_lang = "C"},
  
            new Employee1() {emp_id = 302, emp_name = "Sona ",
                                          emp_lang = "Java"},
                                            
            new Employee1() {emp_id = 303, emp_name = "Lana ",
                                          emp_lang = "Java"},
                                            
            new Employee1() {emp_id = 304, emp_name = "Lion ",
                                            emp_lang = "C#"},
                                              
            new Employee1() {emp_id = 305, emp_name = "Ramona",
                                             emp_lang = "Java"},
  
        };
  
        List<Employee2> emp2 = new List<Employee2>() {
  
            new Employee2() {emp_id = 300, emp_dept = "Designing",
                                              emp_salary = 23000},
  
            new Employee2() {emp_id = 301, emp_dept = "Developing",
                                               emp_salary = 40000},
  
            new Employee2() {emp_id = 302, emp_dept = "HR",
                                       emp_salary = 50000},
  
            new Employee2() {emp_id = 303, emp_dept = "Designing",
                                              emp_salary = 60000},
  
        };
  
        // Query to find the name and
        // the salary of the employees
        // Using Inner Join
        var res = from e1 in emp1
                    join e2 in emp2
                        on e1.emp_id equals e2.emp_id
                            select new 
                            {
                                Emp_Name = e1.emp_name,
                                Emp_Salary = e2.emp_salary
                            };
  
        // Display result
        Console.WriteLine("Employee and their Salary: ");
        Console.WriteLine("==========================");
        foreach(var val in res)
        {
            Console.WriteLine("Employee Name: {0}   | Salary: {1}",
                                 val.Emp_Name, val.Emp_Salary);
        }
        string b = "Execution Completed Successfully!";
        System.Console.WriteLine("Array: {0}",b + " time: 1.5sec");
    }
  }
}
