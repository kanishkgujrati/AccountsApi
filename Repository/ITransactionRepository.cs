using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public interface ITransactionRepository
    {
       

        public Task<bool>FundTransfer(long accountId,long beneficiaryId,decimal amount);

       
        public Task<IEnumerable<Transaction>>TransactionsList(long accoundId);
    }
}
