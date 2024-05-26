using AccountsApi.Model;

namespace AccountsApi.Repository
{
    public interface IBeneficiaryRepository
    {
       public  Task<Beneficiary> Addbeneficiary(Beneficiary beneficiary);

       public Task<IEnumerable<Beneficiary>> ListBeneficiary(long accoundId);

       public Task<bool>DeleteBenficiary(long beneficiaryId);
    }
}
