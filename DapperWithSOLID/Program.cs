using DapperWithSOLID.Controller;
using DapperWithSOLID.Model;
using System;
using System.Collections.Generic;

namespace DapperWithSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkDb conn = new WorkDb();
            bool checkUser = true;
            while (checkUser)
            {
                Console.WriteLine("1.Посмотреть всех студентов\n2.Посмотреть по id\n3.Добавить студента в БД\n4.Удалить студента\n5.Выход");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.Write("ID \t");
                        Console.Write("FullName \t");
                        Console.Write("Team \t");
                        Console.WriteLine("Course \t");
                        List<Students> sct = conn.Select();
                        foreach (var i in sct)
                        {
                            Console.WriteLine(i.Id + "\t" + i.FullName + "\t" + i.Team + "\t" + i.Course);
                        }
                        break;
                    case 2:
                        Console.Write("Введите id: ");
                        Students newU = conn.Select(int.Parse(Console.ReadLine()));
                        Console.WriteLine("ID: " + newU.Id + " FullName: " + newU.FullName + " Team: " + newU.Team);
                        break;
                    case 3:
                        conn.Add();
                        break;
                    case 4:
                        Console.Write("Введите id для удаление: ");
                        int id = int.Parse(Console.ReadLine());
                        conn.Remove(id);
                        break;
                    case 5:
                        checkUser = false;
                        break;
                    default:
                        break;
                }
                
            }
            
        }
    }
}
