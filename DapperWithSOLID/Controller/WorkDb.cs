using DapperWithSOLID.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWithSOLID.Controller
{
    class WorkDb
    {
        AddUser<Students> add = null;
        SelectTheUser<Students> s = null;

        public WorkDb()
        {

        }

        public Students select(int id)
        {
            s = new SelectTheUser<Students>();
            s.OpenConnection();
            return s.SelectById(id);
        }
    }
}
