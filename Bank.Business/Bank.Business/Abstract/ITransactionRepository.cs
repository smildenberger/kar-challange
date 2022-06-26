using Bank.Business.Entities;
using Bank.Business.Entities.Accounts;
using Bank.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Abstract {
    public interface ITransactionRepository {
        public TransactionResponse Add(Transaction transaction);
        public decimal GetBalance(AccountBase account);
    }
}
