using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
  class Customer
  {

  }
  class Program
  {
Program()
{
  System.Console.WriteLine("Constructor");
}
~Program()
{
  System.Console.WriteLine("Destructor");
}
public class Bank
{
  
        private double balance;
        public double getBalance()
        {
            //add validation logic if needed
            System.Console.WriteLine("Encapsuleatien");
            return balance;
        }
        public void setBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                // validate the value
                if (value < 0)
                {
                    Console.WriteLine("value cannot be negative");
                }
                else
                {
                    balance = value;
                }
            }
        }
        static int ban()
        {
          System.Console.WriteLine("Static method");
          return 1;
        }
}
    static void Main(string[] args)
    {
              // Console.BackgroundColor = ConsoleColor.DarkRed;
              // Console.ForegroundColor = ConsoleColor.Black;
            Bank SBI = new Bank();
            SBI.Balance = 100;
            Console.WriteLine(SBI.Balance);
            SBI.Balance = -50;
            Console.WriteLine(SBI.Balance);
                        SBI.setBalance(500);
            Console.WriteLine(SBI.getBalance());
Program.ban();
            // b.car();  
      Console.WriteLine("Hello World!");
      List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
      IEnumerable<int> QuerySyntax = from obj in integerList
      where obj > 5
      select obj;
      foreach(var i in QuerySyntax)
      {
        System.Console.WriteLine("Item"+ i);
      }

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
      System.Console.WriteLine("Minimum number is: {0:F2} {1} {2} {3}", minimum, 5, 12, 16, 20, 21);

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
      foreach (var val1 in res)
      {
        Console.WriteLine("Employee Name: {0}   | Salary: {1}",
                             val1.Emp_Name, val1.Emp_Salary);
      }
      string b = "Execution Completed Successfully!";
      System.Console.WriteLine("Array: {0}", b + " time: 1.5sec");
      int num;
      num = Convert.ToInt32(Console.ReadLine());
      switch (num)
      {
        case 1:
          System.Console.WriteLine("You Entered Number: \"One\"");
          break;
        case 2:
          System.Console.WriteLine("You Entered Number: \"Two\"");
          break;
        default:
          System.Console.WriteLine("Numbers 1 and 2 only");
          break;
      }
      int[] arr = new int[5];

      Program p = new Program();
      Customer c = new Customer();
      p.get(12);
      System.Console.WriteLine(p.get(11));
GC.Collect();
      int val = 50;
      Program program = new Program(); // Creating Object  
      Console.WriteLine("Value before calling the function " + val);
      program.Show(val); // Calling Function by passing value            
      Console.WriteLine("Value after calling the function " + val);

     int[] arr1 = { 25, 10, 20, 15, 40, 50 };  
        int[] arr2 = { 12, 23, 64, 11, 54 };  
        printMax(arr1);//passing array to function  
        printMax(arr2); 

         int[,] arr3=new int[3,3];//declaration of 2D array  
        arr3[0,1]=10;//initialization  
        arr3[1,2]=20;  
        arr3[2,0]=30;  
  
        //traversal  
        for(int i=0;i<3;i++){  
            for(int j=0;j<3;j++){  
                Console.Write(arr3[i,j]+" ");  
            }  
            Console.WriteLine();//new line at each row  
        }  
string str1 = "Dot";
str1 = "Net";
System.Console.WriteLine(str1);
System.Console.WriteLine(str1);

    }

    private static void ban()
    {
      System.Console.WriteLine("Statci meteod");
      // throw new NotImplementedException();
    }

    static void printMax(int[] arr)  
    {  
        int max = arr[0];  
        for (int i = 1; i < arr.Length; i++)  
        {  
            if (max < arr[i])  
            {  
                max = arr[i];  
            }  
        }  
        Array.Sort(arr); 
        System.Console.WriteLine(arr);
        Console.WriteLine("Maximum element is: " + max);  
    }  

    private int get(int num1)
    {
      num1 = 25678;
      System.Console.WriteLine("print print!!");
      return num1;
    }
    public void Show(int val)
    {
      val *= val; // Manipulating value  
      Console.WriteLine("Value inside the show function {0} {1}", val, 3500);
      // No return statement  
    }
  }
}
