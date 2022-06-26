using Bank.Business.Abstract;
using Bank.Business.Entities;
using Bank.Business.Entities.Accounts;
using Bank.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Services {
    public class AccountService : IAccountService {
        private readonly ITransactionRepository transactionRepository;
        public AccountService(ITransactionRepository transactionRepository) {
            this.transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
        }

        public TransactionResponse Deposit(AccountBase account, decimal amount) {
            throw new NotImplementedException();
        }

        public TransactionResponse Transfer(AccountBase account, decimal amount, AccountBase toAccount) {
            throw new NotImplementedException();
        }

        public TransactionResponse Withdraw(AccountBase account, decimal amount) {
            var result = new TransactionResponse();

            if (amount > account.WithdrawalLimit) {
                result.ErrorMessage = "Withdrawal amount larger than allowed limit.";
            } else if (amount > account.Balance) {
                result.ErrorMessage = "Withdrawal amount larger than current balace";
            } else {
                var transaction = new Transaction {
                    Account = account,
                    Amount = amount,
                    TransactionType = Enumerations.TransactionType.Withdrawal
                };

                result = transactionRepository.Add(transaction);
            }

            return result;
        }
    }
}
