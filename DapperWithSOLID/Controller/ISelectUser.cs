using System.Collections.Generic;

namespace DapperWithSOLID.Controller
{
    interface ISelectUser<T>
    {
        T SelectById(int id);
        List<T> SelectAll();
    }
}
