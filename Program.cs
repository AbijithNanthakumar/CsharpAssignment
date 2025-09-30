
using System;

// Constructor chaining and Method Overloading
//public class Student
//{
//    string name;
//    int age;
//    int marks;

//    public Student()
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public Student(string name,int age) : this() 
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public Student(string name,int age,int marks) : this(name,age)
//    {
//        this.marks = marks;


//    }

//    public void display()
//    {
//        Console.WriteLine(name+"  "+age+"  "+marks);
//    }
//}


//class Program
//{
//    static void Main()
//    {
//       Student student = new Student("Abijith",22,95);
//       student.display();
//    }
//}


// Const and ReadOnly

class Student
{
    public const int ab = 10;

    //ab = 20; // Cannot be modified
}
//class Program
//{
    
//    static void Main()
//    {
        
//    }
//}