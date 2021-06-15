using GiftAidManager.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidManager.Core.AccountAggregate
{
    public class Transaction : BaseEntity
    {
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int Value { get; set; }
    }
}
