namespace InfinityWorks.TechTest.Core.Features.GetLocalAuthorities
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using InfinityWorks.TechTest.Client;
    using System.Linq;
    using InfinityWorks.TechTest.Core.Domain;

    public class GetLocalAuthoritiesHandler : IRequestHandler<GetLocalAuthoritiesRequest, GetLocalAuthoritiesResponse>
    {
        private readonly IFsaClient _client;

        public GetLocalAuthoritiesHandler(IFsaClient client)
        {
            _client = client;
        }

        public async Task<GetLocalAuthoritiesResponse> Handle(GetLocalAuthoritiesRequest request, CancellationToken cancellationToken)
        {
            var result = await _client.GetAuthorities();

            return new GetLocalAuthoritiesResponse(result.Authorities.Select(authority => new LocalAuthority(id: authority.LocalAuthorityId, name: authority.Name)));
        }
    }
}
