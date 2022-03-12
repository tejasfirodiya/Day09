//// See https://aka.ms/new-console-template for more information
////StudentRecord sr = new StudentRecord();
////sr.Test();

////Module.Subjects();



//class StudentRecord
//{
//    Student s = new Student("Tejas", 22, "Maths", "Social", "Programming", 100, 99, 98);

//    public void Test()
//    {
//        Console.WriteLine("###### College Student System ######");
//        Console.WriteLine("1> Add Record");
//        Console.WriteLine("2> Update Record");
//        Console.WriteLine("3> Get Any Record");
//        Console.WriteLine("4> Get All Record");
//        Console.WriteLine("5> Add Module");
//        Console.WriteLine("6> Get any module details");
//        Console.WriteLine("7> Get All module details");
//        Console.WriteLine("8> Update Module");
//        Console.WriteLine("9> Find std marks");
//        Console.WriteLine("0> Exit..");
//        Console.WriteLine("Enter your choice : ");
//        var choice = Console.ReadLine();

//        if (choice == "1")
//        {
//            s.addStudentRecord();
//        }
//        else if (choice == "2")
//        {
//            s.updateStudent();
//        }
//        else if (choice == "3")
//        {
//            s.displayStudentRecord();
//        }
//        else if (choice == "4")
//        {
//            s.displayAllStudentRecord();
//        }
//        else if (choice == "5")
//        {
//            s.findStudentMarks();
//        }
//        else if (choice == "0")
//        {
//            Console.WriteLine("*************** Thank You!!!! ***************");
//        }

//    }
//}

//class Student
//{
//    public string name;
//    public int age;
//    public string subj1, subj2, subj3;
//    public int mark1, mark2, mark3;

//    public Student(string name, int age, string subj1, string subj2, string subj3, int mark1, int mark2, int mark3)
//    {
//        this.name = name;
//        this.age = age;
//        this.subj1 = subj1;
//        this.subj2 = subj2;
//        this.subj3 = subj3;
//        this.mark1 = mark1;
//        this.mark2 = mark2;
//        this.mark3 = mark3;
//    }

//    public void addStudentRecord()
//    {
//        Console.WriteLine("How many students you want to insert : ");
//        var name = Console.ReadLine();

//        Console.WriteLine("Enter Name of Student : ");
//        var name = Console.ReadLine();

//        Console.WriteLine("Enter Age of Student : ");
//        var age = Console.ReadLine();
//        Console.WriteLine("Enter Name of Student : ");
//        var name = Console.ReadLine();


//        Console.WriteLine("Enter Subjects of Student : ");
//        var name = Console.ReadLine();

//        Console.WriteLine("Enter Name of Student : ");
//        var name = Console.ReadLine();


//        Console.WriteLine($"Name of student is : {name} ");
//    }

//    public void updateStudent()
//    {

//    }

//    public void displayStudentRecord()
//    {

//    }
//    public void displayAllStudentRecord()
//    {

//    }
//    public void findStudentMarks()
//    {

//    }
//}

////public enum Subject
////{
////    NotProvided,
////    Science,
////    Hindi,
////    Marathi

////}

////public class Module
////{
////    public static void Subjects()
////    {
////        Subject subject = Subject.NotProvided;

////        Console.WriteLine($"1. Subject = {subject}");

////        Console.WriteLine("Enter subject : ");
////        var subjectText = Console.ReadLine();    // male/female

////        subject = (Subject)Enum.Parse(typeof(Subject), subjectText);

////        Console.WriteLine($"2. Subject = {subject}");
////    }
////}