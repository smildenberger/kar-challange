using Bank.Business.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Entities {
    public class BankBase {
        public string Name { get; set; }
        public IEnumerable<AccountBase> Accounts { get; set; }
    }
}
