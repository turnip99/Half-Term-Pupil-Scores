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
            Console.Clear();
            int h = 0;
            var z = new TestData();
            z.ID = "323";
            z.name = "Bob";
            z.gender = "Male";
            z.test1 = 1;
            z.test2 = 1;
            z.midterm = 1;
            z.final = 2;
            z.total = 5;
            studentList.Add(z);
            z.ID = "522";
            z.name = "Fred";
            z.gender = "Male";
            z.test1 = 1;
            z.test2 = 1;
            z.midterm = 64;
            z.final = 55;
            z.total = 121;
            studentList.Add(z);
            z.ID = "674";
            z.name = "Jim";
            z.gender = "Male";
            z.test1 = 8;
            z.test2 = 4;
            z.midterm = 21;
            z.final = 33;
            z.total = 66;
            studentList.Add(z);
            z.ID = "332";
            z.name = "Kerry";
            z.gender = "Female";
            z.test1 = 4;
            z.test2 = 54;
            z.midterm = 5;
            z.final = 76;
            z.total = 139;
            studentList.Add(z);
            List<TestData> volitileList = new List<TestData>();
            List<string> sortedID = new List<string>();
            List<string> sortedName = new List<string>();
            List<float> sortedValue = new List<float>();
            List<string> sortedGender = new List<string>();
            List<float> sortedTest1 = new List<float>();
            List<float> sortedTest2 = new List<float>();
            List<float> sortedTest3 = new List<float>();
            List<float> sortedTest4 = new List<float>();
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
                Console.WriteLine("7. Show Student with lowest total score");
                Console.WriteLine("8. Find student by ID");
                Console.WriteLine("9. Sort students by total scores");
                Console.Write("Enter your selection: ");
                bool valid = false;
                bool valid2;
                string selection;
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
                        case "2":
                            Console.Clear();
                            valid2 = false;
                            Console.Write("Please enter the student ID you wish to delete: ");
                            selection = Console.ReadLine();
                            foreach (TestData item in studentList)
                            {
                                if (selection == item.ID)
                                {
                                    valid2 = true;
                                    studentList.Remove(item);
                                    Console.WriteLine("Student {0} has been deleted from the database.", selection);
                                    break;
                                }
                            }
                            if (valid2 == false)
                            {
                                Console.WriteLine("Sorry, this is not a recognised ID.");
                            }
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            valid2 = false;
                            Console.Write("Please enter the student ID you wish to update: ");
                            selection = Console.ReadLine();
                            foreach (TestData item in studentList)
                            {
                                if (selection == item.ID)
                                {
                                    studentList.Remove(item);
                                    valid2 = true;
                                    var x = new TestData();
                                    float[] testScoresForXToFixBug = new float[4];
                                    x.ID = selection;
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
                                    Console.WriteLine("This student's data has been replaced.");
                                    break;
                                }
                            }
                            if (valid2 == false)
                            {
                                Console.WriteLine("Sorry, this is not a recognised ID.");

                            }
                            Console.ReadLine();
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
                        case "5":
                            Console.Clear();
                            valid2 = false;
                            Console.Write("Please enter the student ID you wish to find the average score of: ");
                            selection = Console.ReadLine();
                            foreach (TestData item in studentList)
                            {
                                if (selection == item.ID)
                                {
                                    valid2 = true;
                                    Console.WriteLine("The average test score for student {0} is {1}.",item.ID, item.total/4);
                                    break;
                                }
                            }
                            if (valid2 == false)
                            {
                                Console.WriteLine("Sorry, this is not a recognised ID.");
                            }
                            Console.ReadLine();
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("The highest score was ");
                            break;
                        case "9":
                            Console.Clear();
                            sortedID.Clear();
                            sortedName.Clear();
                            sortedGender.Clear();
                            sortedTest1.Clear();
                            sortedTest2.Clear();
                            sortedTest3.Clear();
                            sortedTest4.Clear();
                            sortedValue.Clear();
                            volitileList = studentList;
                            for (int x = volitileList.Count; x > 0; x--)
                            {
                                TestData highest = volitileList[0];
                                float highestValue = highest.total;
                                string highestID = highest.ID;
                                string highestName = highest.name;
                                string highestGender = highest.gender;
                                float highestScore1 = highest.test1;
                                float highestScore2 = highest.test2;
                                float highestScore3 = highest.midterm;
                                float highestScore4 = highest.final;
                                for (int i = 1; i < volitileList.Count; i++)
                                {
                                    if (volitileList[i].total > highestValue)
                                    {
                                        highest = volitileList[i];
                                        highestValue = volitileList[i].total;
                                        highestID = volitileList[i].ID;
                                        highestName = volitileList[i].name;
                                        highestGender = volitileList[i].gender;
                                        highestScore1 = volitileList[i].test1;
                                        highestScore2 = volitileList[i].test2;
                                        highestScore3 = volitileList[i].midterm;
                                        highestScore4 = volitileList[i].final;
                                    }
                                }
                                sortedID.Add(highestID);
                                sortedName.Add(highestName);
                                sortedValue.Add(highestValue);
                                sortedGender.Add(highestGender);
                                sortedTest1.Add(highestScore1);
                                sortedTest2.Add(highestScore2);
                                sortedTest3.Add(highestScore3);
                                sortedTest4.Add(highestScore4);
                                volitileList.RemoveAll(l => l.ID == highestID);
                            }
                            for (int i = 0; i < sortedValue.Count; i++)
                            {
                                z.ID = sortedID[i];
                                z.name = sortedName[i];
                                z.gender = sortedGender[i];
                                z.test1 = sortedTest1[i];
                                z.test2 = sortedTest2[i];
                                z.midterm = sortedTest3[i];
                                z.final = sortedTest4[i];
                                z.total = sortedValue[i];
                                studentList.Add(z);
                            }
                            Console.WriteLine("There are {0} values in the list", studentList.Count);
                            Console.ReadLine();
                            Console.WriteLine("The database has been permenantly reordered.");
                            Console.WriteLine("Here are the values of the student's sorted total scores: \n");
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
                            h = studentList.Count;
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
