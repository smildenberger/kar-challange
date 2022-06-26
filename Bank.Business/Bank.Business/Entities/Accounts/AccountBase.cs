using static Bank.Business.Enumerations;

namespace Bank.Business.Entities.Accounts {
    public class AccountBase {

        internal AccountBase(AccountType accountType, decimal balance, BankBase bank, Owner owner) {
            AccountType = accountType;
            Balance = balance;
            Bank = bank;
            Owner = owner;
        }

        public virtual AccountType AccountType { get; private set; }
        public decimal Balance { get; set; }
        public BankBase Bank { get; private set; }
        public Owner Owner { get; private set; }

        public virtual decimal WithdrawalLimit => throw new NotImplementedException("Withdrawal Limit Not Defined");
    }
}