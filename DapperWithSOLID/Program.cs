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
            Console.WriteLine("1.Посмотреть всех студентов\n2.Посмотреть по id\n3.Добавить студента в БД\n4.Выход");
            int c = int.Parse(Console.ReadLine());
            while (true)
            {
                if (c == 1)
                {
                    
                    
                } else if(c == 2)
                {
                    Console.Write("Введите id: ");
                    Students newU = conn.select(int.Parse(Console.ReadLine()));
                    Console.WriteLine("ID: "+newU.Id+" FullName: "+newU.FullName+" Team: "+newU.Team);
                }
            }

            Console.ReadKey();
        }
    }
}
