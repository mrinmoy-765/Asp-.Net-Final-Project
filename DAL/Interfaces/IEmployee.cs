using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEmployee<CLASS, ID, RESULT>
    {
        RESULT AddEmployee(CLASS employee);
        bool DeleteEmployee(ID id);
        List<CLASS> GetAllEmployees();
        CLASS GetEmployee(ID id);
    }
}
