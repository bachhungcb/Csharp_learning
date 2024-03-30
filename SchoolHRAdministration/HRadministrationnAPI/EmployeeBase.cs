using System;
using System.Collections.Generic;
using System.Text;

namespace HRadministrationnAPI
{
   public class EmployeeBase : IEemployee
    {
        public int Id { get; set; }

         public string FirstName { get; set; }

         public string LastName { get; set; }
         public virtual decimal Salary { get; set; }

    }

}
