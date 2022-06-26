using Bank.Business.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.Business.Enumerations;

namespace Bank.Business.Entities {
    public class Transaction {
        public TransactionType TransactionType { get; set; }
        public AccountBase Account { get; set; }
        public decimal Amount { get; set; }
    }
}
