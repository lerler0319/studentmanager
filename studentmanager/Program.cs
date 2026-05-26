using System;
namespace StudentManager
{
    struct Student
    {
        public string id;
        public int age;
        public string name;
        public int classname;


    }
    class Program
    {
        static Student[] student = new Student[50];
        static int count = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.AddStudent    2.ShowAll    3.end    4.searchStudentid    5.delete student     6.update student");
                if (!int.TryParse(Console.ReadLine(), out int choose))
                {
                    Console.WriteLine("输入错误，请输入数字！");
                    continue;
                }
                if (choose == 1)
                {
                    AddStudent();
                    Console.WriteLine("new student ok");
                }
                else if (choose == 2)
                {
                    ShowAll();
                    Console.WriteLine("student show over");
                }
                else if (choose == 3)
                {
                    break;
                }
                else if (choose == 4)
                {
                    SearchStudentid();
                }
                else if (choose==5)
                {
                    DeleteStudent();
                }
                else if(choose==6)
                {
                    UpdateStudent();
                }
                else
                {
                    Console.WriteLine("wrong again");

                }
            }
        }

        static void AddStudent()
        {
            bool found;
            do
            {
                found = false;
                Console.WriteLine("学号；");
                student[count].id = Console.ReadLine();
                for (int i = 0; i < count; i++)
                {
                    if (student[count].id == student[i].id)
                    {
                        Console.WriteLine("the studentid is repeat,please put in new studentid!!");
                        found = true;
                    }
                }
            }
            while (found);
                Console.WriteLine("年龄;");
                student[count].age = int.Parse(Console.ReadLine());
                Console.WriteLine("姓名");
                student[count].name = Console.ReadLine();
                Console.WriteLine("classname");
                student[count].classname = int.Parse(Console.ReadLine());
           

            count++;
        }
        static void ShowAll()
        {
            Console.WriteLine("all student");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("id{0},age{1},name{2},classname{3}", student[i].id, student[i].age, student[i].name, student[i].classname);
            }

        }
        static void SearchStudentid()

        {
            bool found = false;
            Console.WriteLine("输入要查找的学生学号");
            string studentid = Console.ReadLine();
            for (int x = 0; x < count; x++)
            {
                if (student[x].id == studentid)
                {
                    Console.WriteLine("search over ,student classname{0},student name{1},student age{2}", student[x].classname, student[x].name, student[x].age);
                    found = true; break;
                }

            }
            if (!found)
            {
                Console.WriteLine("the studentid is wrong,please put in right studentid again!!");

            }
        }
        static void DeleteStudent()
        {
            Console.WriteLine("please putin the student you will delete");
            string studentid = Console.ReadLine();
            bool found = false;
            for (int x = 0; x < count; x++)
            {
                if (student[x].id == studentid)
                {
                    Console.WriteLine("the studentid is right,will delete the student");
                   for(int j=x;j<count-1;j++)
                    {
                        student[j]=student[j+1];
                    }
                    count--;
                    found = true; break;

                }
            }
            if(!found)
            {
                Console.WriteLine("the studentid is wrong,please putin right studentid again!!");

            }
        }
        static void UpdateStudent()
        {
            Console.WriteLine("put in the studentid you will update");
            string oldstudent= Console.ReadLine();
            bool found= false;
            for(int x = 0;x < count; x++)
            {
                if(student[x].id == oldstudent)
                {
                    Console.WriteLine("the studentid is right");
                    Console.WriteLine("please update the studentname");
                    student[x].name = Console.ReadLine();
                    Console.WriteLine("please update the studentid");
                    student[x].id = Console.ReadLine();
                    Console.WriteLine("please update the studentage");
                    student[x].age=int.Parse(Console.ReadLine());
                    Console.WriteLine("please update the studentclassname");
                    student[x].classname=int.Parse(Console.ReadLine()) ;
                    Console.WriteLine("all have updated");
                    found = true; break;
                    
                }
             

            }
            if(!found)
            {
                Console.WriteLine("the studentid is wrong,please try again!!");
            }

        }
    }
}

