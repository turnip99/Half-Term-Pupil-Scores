using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Term_Pupil_Score
{
    class Program
    {
        struct TestData
        {
            public string ID;
            public string name;
            public string gender;
            public float test1;
            public float test2;
            public float midterm;
            public float final;
            public float total;
        };
        static void Main(string[] args)
        {
            List<TestData> studentList = new List<TestData>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Add student records");
                Console.WriteLine("2. Delete student records");
                Console.WriteLine("3. Update Student Records");
                Console.WriteLine("4. View all student records");
                Console.WriteLine("5. Calculate average of select student's scores");
                Console.WriteLine("6. Show student with the highest max score");
                Console.WriteLine("7. Show Student by lowest total score");
                Console.WriteLine("8. Find student by ID");
                Console.WriteLine("9. Sort students by total scores");
                Console.Write("Enter your selection: ");
                bool valid = false;
                bool valid2;
                while (valid == false)
                {
                    valid = true;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            string repeat;
                            do
                            {
                                float[] testScoresForXToFixBug = new float[4];
                                Console.Clear();
                                var x = new TestData();
                                Console.Write("Please enter the student's ID: ");
                                x.ID = Console.ReadLine();
                                Console.Write("Please enter the student's name: ");
                                x.name = Console.ReadLine();
                                Console.Write("Please enter the student's gender (M/F): ");
                                valid2 = false;
                                while (valid2 == false)
                                {
                                    string genderInitial = Console.ReadLine().ToUpper();
                                    if (genderInitial == "M" || genderInitial == "F")
                                    {
                                        if (genderInitial == "M")
                                        {
                                            x.gender = "Female";
                                        }
                                        else
                                        {
                                            x.gender = "Male";
                                        }
                                        valid2 = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid gender, try again.");
                                    }
                                }
                                x.total = 0;
                                Console.Write("Please enter the first test score: ");
                                valid2 = false;
                                while (valid2 == false)
                                {
                                    string testInitial;
                                    testInitial = Console.ReadLine().ToUpper();
                                    if (float.TryParse(testInitial, out x.test1))
                                    {
                                        valid2 = true;
                                        x.total = x.total + x.test1;
                                        testScoresForXToFixBug[0] = x.test1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid number, try again.");
                                    }
                                }
                                Console.Write("Please enter the second test score: ");
                                valid2 = false;
                                while (valid2 == false)
                                {
                                    string testInitial;
                                    testInitial = Console.ReadLine().ToUpper();
                                    if (float.TryParse(testInitial, out x.test2))
                                    {
                                        valid2 = true;
                                        x.total = x.total + x.test2;
                                        testScoresForXToFixBug[1] = x.test2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid number, try again.");
                                    }
                                }
                                Console.Write("Please enter the mid-term test score: ");
                                valid2 = false;
                                while (valid2 == false)
                                {
                                    string testInitial;
                                    testInitial = Console.ReadLine().ToUpper();
                                    if (float.TryParse(testInitial, out x.midterm))
                                    {
                                        valid2 = true;
                                        x.total = x.total + x.midterm;
                                        testScoresForXToFixBug[2] = x.midterm;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid number, try again.");
                                    }
                                }
                                Console.Write("Please enter the final test score: ");
                                valid2 = false;
                                while (valid2 == false)
                                {
                                    string testInitial;
                                    testInitial = Console.ReadLine().ToUpper();
                                    if (float.TryParse(testInitial, out x.final))
                                    {

                                        valid2 = true;
                                        x.total = x.total + x.final;
                                        testScoresForXToFixBug[3] = x.final;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid number, try again.");
                                    }
                                }
                                x.test1 = testScoresForXToFixBug[0];
                                x.test2 = testScoresForXToFixBug[1];
                                x.midterm = testScoresForXToFixBug[2];
                                x.final = testScoresForXToFixBug[3];
                                studentList.Add(x);
                                Console.Write("Do you want to add another student? (Y): ");
                                repeat = Console.ReadLine().ToUpper();
                            } while (repeat == "Y");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Here are the values of all student records: \n");
                            foreach (TestData item in studentList)
                            {
                                Console.WriteLine("ID: {0}", item.ID);
                                Console.WriteLine("Name: {0}", item.name);
                                Console.WriteLine("Gender: {0}", item.gender);
                                Console.WriteLine("First Test Score: {0}", item.test1);
                                Console.WriteLine("Second Test Score: {0}", item.test2);
                                Console.WriteLine("Mid-Term Test Score: {0}", item.midterm);
                                Console.WriteLine("Final Test Score: {0}", item.final);
                                Console.WriteLine("Total of Test Scores: {0} \n", item.total);
                            }
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                            valid = false;
                            break;
                    }
                }
            }
            
        }
    }
}
