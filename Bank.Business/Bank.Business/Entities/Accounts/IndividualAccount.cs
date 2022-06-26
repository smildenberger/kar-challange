using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.Business.Enumerations;

namespace Bank.Business.Entities.Accounts {
    public class IndividualAccount : AccountBase {

        public IndividualAccount(BankBase bank, Owner owner, decimal balance) : base(AccountType.Individual, balance, bank, owner) {
        }
        public override decimal WithdrawalLimit => 500.00M;  // TODO: get from configuration table
    }
}
