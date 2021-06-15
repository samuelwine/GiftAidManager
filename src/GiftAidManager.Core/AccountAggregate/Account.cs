using GiftAidManager.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidManager.Core.AccountAggregate
{
    class Account : BaseEntity
    {
        public int CustomerId { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();


        private int _balance;
        public int Balance
        {
            get 
            {
                foreach (var transaction in Transactions)
                {
                    _balance += transaction.Value;
                }
                return _balance; 
            }
        }

    }
}
