namespace InfinityWorks.TechTest.Core.Features.GetLocalAuthorityEstablishmentRatings
{
    using InfinityWorks.TechTest.Client;
    using InfinityWorks.TechTest.Core.Domain;
    using MediatR;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetLocalAuthorityEstablishmentRatingsHandler : IRequestHandler<GetLocalAuthorityEstablishmentRatingsRequest, GetLocalAuthorityEstablishmentRatingsResponse>
    {
        private readonly IFsaClient _client;

        public GetLocalAuthorityEstablishmentRatingsHandler(IFsaClient client)
        {
            _client = client;
        }

        public async Task<GetLocalAuthorityEstablishmentRatingsResponse> Handle(GetLocalAuthorityEstablishmentRatingsRequest request, CancellationToken cancellationToken)
        {
            var establishmentList = await _client.GetEstablishmentByAuthority(request.Id);

            var total = establishmentList.Establishments.Count();

            return new GetLocalAuthorityEstablishmentRatingsResponse(id : request.Id, ratings: from e in establishmentList.Establishments                                                                                                
                                                                                               group e by e.RatingValue into names
                                                                                               let name = names.Key
                                                                                               let percentage = (double)(100 * names.Count()) / total
                                                                                               select new Rating(name: name, percentage: percentage));
        }
    }
}
