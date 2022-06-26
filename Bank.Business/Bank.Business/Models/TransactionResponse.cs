using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business.Models {
    public class TransactionResponse {
        public string ErrorMessage { get; set; }
        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage);
    }
}
