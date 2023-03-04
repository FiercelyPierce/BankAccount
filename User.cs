using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Balance { get; set; }

        public User() 
        {
            Id = 0;
            Name = string.Empty;
            Balance = string.Empty;

        }

    }
}
