using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingAppDbContext _bankingAppDbContext;
        public async Task<Account> CreateNew(Account account)
        {
            throw new NotImplementedException();
        }

        public async Task<bool>DeleteAccount(long accountId)
        {
            throw new NotImplementedException();
        }

        public async Task<Account>GetDetails(long accountId)
        {
            throw new NotImplementedException();
        }
    }
}
