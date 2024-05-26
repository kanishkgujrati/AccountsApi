using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public class BeneficiaryRepository : IBeneficiaryRepository
    {
        private readonly BankingAppDbContext _bankingAppDbContext;

        public async Task<Beneficiary> Addbeneficiary(Beneficiary beneficiary)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteBenficiary(long beneficiaryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Beneficiary>> ListBeneficiary(long accoundId)
        {
            throw new NotImplementedException();
        }
    }
}
