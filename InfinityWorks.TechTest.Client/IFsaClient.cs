namespace InfinityWorks.TechTest.Client
{
    using InfinityWorks.TechTest.Client.Model;
    using System.Threading.Tasks;

    public interface IFsaClient
    {
        Task<FsaAuthorityList> GetAuthorities();

        Task<FsaEstablishmentList> GetEstablishmentByAuthority(int localAuthorityId, int pageSize = 10000);
    }
}