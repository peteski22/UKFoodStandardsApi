namespace InfinityWorks.TechTest.Core.Features.GetLocalAuthorities
{
    using InfinityWorks.TechTest.Core.Domain;
    using System.Collections.Generic;

    public class GetLocalAuthoritiesResponse
    {
        public IEnumerable<LocalAuthority> Authorities { get; }

        public GetLocalAuthoritiesResponse(IEnumerable<LocalAuthority> authorities)
        {
            Authorities = authorities;
        }
    }
}
