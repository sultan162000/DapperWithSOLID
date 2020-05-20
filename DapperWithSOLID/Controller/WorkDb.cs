using DapperWithSOLID.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWithSOLID.Controller
{
    class WorkDb
    {
        AddUser<Students> add = null;
        SelectTheUser<Students> s = new SelectTheUser<Students>();
        RemoveStd<Students> r = null;

        public WorkDb()
        {

        }

        public Students Select(int id)
        {
            s = new SelectTheUser<Students>();
            s.OpenConnection();
            return s.SelectById(id);
        }

        public List<Students> Select()
        {
            s = new SelectTheUser<Students>();
            s.OpenConnection();
            return s.SelectAll();
        }


        public void Add()
        {
            add = new AddUser<Students>();
            add.OpenConnection();
            string name;
            do
            {
                Console.Write("Введите полное имя студента: ");
                name = Console.ReadLine();

            } while (string.IsNullOrEmpty(name) && name.Length < 7);
            
            byte course;
            while (true)
            {
                Console.Write("Введите курс");
                course = byte.Parse(Console.ReadLine());
                if (course > 5 && course < 0) break;
            }
            int team;
            while (true)
            {
                Console.Write("Группа: ");
                team = int.Parse(Console.ReadLine());
                if (team.ToString().Length>6) break;
            }
            Students newSt = new Students() { FullName = name, Course = course, Team = team };
            add.Add(newSt);
            add.CloseConnection();

        }
        public void Remove(int id)
        {
            r = new RemoveStd<Students>();
            r.OpenConnection();
            r.Remove(s, id);

        }
    }
}
