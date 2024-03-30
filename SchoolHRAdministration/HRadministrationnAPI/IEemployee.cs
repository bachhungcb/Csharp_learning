using System;
using System.Collections.Generic;
using System.Text;

namespace HRadministrationnAPI
{
    public interface IEemployee
    {
         int Id { get; set; }

         string FirstName {get; set;}

         string LastName { get; set; }
         decimal Salary { get; set; }



    }
}
