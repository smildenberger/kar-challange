using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.Business.Enumerations;

namespace Bank.Business.Entities.Accounts {
    public class CorporateAccount : AccountBase {
        public CorporateAccount(BankBase bank, Owner owner, decimal balance) : base(AccountType.Individual, balance, bank, owner) {
        }

        public override decimal WithdrawalLimit => Balance;
    }
}
