using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public interface IBeneficiaryRepository
    {
       public  Task<Beneficiary> Addbeneficiary(BeneficiaryInputModel beneficiary);

       public Task<IEnumerable<Beneficiary>> ListBeneficiary(long accountId);

       public Task<bool>DeleteBenficiary(long accountId);
    }
}
