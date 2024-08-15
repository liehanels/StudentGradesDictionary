using System.ComponentModel.DataAnnotations;

namespace StudentGradesSortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> learners = new Dictionary<int, Student>();
            int count = 0;
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Choose an option.");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Add a grade");
                Console.WriteLine("3. Edit a grade");
                Console.WriteLine("4. View grades");
                Console.WriteLine("5. Remove a student");
                Console.WriteLine("6. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    //add student
                    case "1":
                        //gets student name
                        Console.WriteLine("Student Name :");
                        learners.Add(count, new Student(Console.ReadLine() + ""));
                        //confirms addition
                        Console.WriteLine($"Student <{learners.ElementAt(count).Value.getName()}> added.");
                        //increments counter
                        count++;
                        addWait();
                        break;
                    //add grade
                    case "2":
                        //gets student name
                        Console.WriteLine("Student Name :");
                        string search = Console.ReadLine() + "";
                        //find the key of student
                        var key = learners.Where(student => student.Value.getName() == search).ElementAt(0).Key;
                        //gets subject mark
                        Console.WriteLine("Subject Mark :");
                        int mark = int.Parse(Console.ReadLine() + "");
                        //adds the grade
                        learners.ElementAt(key).Value.addGrade(mark);
                        //confirms addition
                        Console.WriteLine($"Added {learners.ElementAt(key).Value.getName()}'s mark of {mark}.");
                        addWait();
                        break;
                    //edit grade
                    case "3":
                        break;
                    //view grades
                    case "4":
                        foreach(var student in learners)
                        {
                            Console.WriteLine(student.Value.getName());
                            foreach(var item in student.Value.getGrades())
                            {
                                Console.WriteLine(item);
                            }
                        }
                        addWait();
                        break;
                    //remove student
                    case "5":

                        break;
                    //exit
                    case "6":
                        Console.WriteLine("Have a nice day!");
                        addWait();
                        exit = true;
                        break;
                }
            }
        }
        public static void addWait()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
