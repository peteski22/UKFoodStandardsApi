namespace InfinityWorks.TechTest.Api
{
    using InfinityWorks.TechTest.Api.Dtos;
    using InfinityWorks.TechTest.Core.Features.GetLocalAuthorities;
    using InfinityWorks.TechTest.Core.Features.GetLocalAuthorityEstablishmentRatings;
    using System.Collections.Generic;
    using System.Linq;

    public static class MappingExtensions
    {
        public static IEnumerable<Authority> Map(this GetLocalAuthoritiesResponse source)
        {
            return source.Authorities.Select(a => new Authority { Id = a.Id, Name = a.Name });
        }

        public static IEnumerable<AuthorityRatingItem> Map(this GetLocalAuthorityEstablishmentRatingsResponse source)
        {
            return source.Ratings.Select(r => new AuthorityRatingItem { Name = r.Name, Value = r.Percentage });
        }
    }
}
