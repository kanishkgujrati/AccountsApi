using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankingAppDbContext _bankingAppDbContext;

       

        public async Task<bool> FundTransfer(long accountId, long beneficiaryId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Transaction>> TransactionsList(long accoundId)
        {
            throw new NotImplementedException();
        }

       
    }
}

