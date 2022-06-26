using Bank.Business.Entities.Accounts;
using Bank.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Abstract {
    public interface IAccountService {
        public TransactionResponse Deposit(AccountBase account, decimal amount);
        public TransactionResponse Transfer(AccountBase account, decimal amount, AccountBase toAccount);
        public TransactionResponse Withdraw(AccountBase account, decimal amount);
    }
}
