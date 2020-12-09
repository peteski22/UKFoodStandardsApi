namespace InfinityWorks.TechTest.Core.Features.GetLocalAuthorityEstablishmentRatings
{
    using InfinityWorks.TechTest.Core.Domain;    
    using System.Collections.Generic;

    public class GetLocalAuthorityEstablishmentRatingsResponse
    {
        public int Id { get; }

        public IEnumerable<Rating> Ratings { get; }

        public GetLocalAuthorityEstablishmentRatingsResponse(int id, IEnumerable<Rating> ratings)
        {
            Id = id;
            Ratings = ratings;
        }
    }
}
