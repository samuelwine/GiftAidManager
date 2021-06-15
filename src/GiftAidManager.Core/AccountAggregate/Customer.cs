using GiftAidManager.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidManager.Core.AccountAggregate
{
    public class Customer : BaseEntity
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string title, string firstName, string lastName)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
