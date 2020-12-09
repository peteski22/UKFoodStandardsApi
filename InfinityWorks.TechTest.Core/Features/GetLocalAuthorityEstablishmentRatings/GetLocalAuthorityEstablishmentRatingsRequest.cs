namespace InfinityWorks.TechTest.Core.Features.GetLocalAuthorityEstablishmentRatings
{
    using MediatR;

    public class GetLocalAuthorityEstablishmentRatingsRequest : IRequest<GetLocalAuthorityEstablishmentRatingsResponse>
    {
        public int Id { get; }

        public GetLocalAuthorityEstablishmentRatingsRequest(int id)
        {
            Id = id;
        }
    }
}
