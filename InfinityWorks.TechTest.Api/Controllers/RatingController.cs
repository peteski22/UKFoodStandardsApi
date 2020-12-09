namespace InfinityWorks.TechTest.Api.Controllers
{
    using System.Threading.Tasks;
    using InfinityWorks.TechTest.Api;
    using InfinityWorks.TechTest.Core.Features.GetLocalAuthorities;
    using InfinityWorks.TechTest.Core.Features.GetLocalAuthorityEstablishmentRatings;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/")]
    [ApiController]
    public class RatingController : Controller
    {
        private readonly IMediator _mediator;

        public RatingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Produces a list of authorities, for the select dropdown
        /// </summary>
        /// <returns>
        /// List of authorities
        /// </returns>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var request = new GetLocalAuthoritiesRequest();
            var result = await _mediator.Send(request);
            return Ok(result.Map());
        }

        /// <summary>
        /// Produces the ratings for a specific authority for the table
        /// </summary>
        /// <param name="authorityId">The authority to calculate ratings for</param>
        /// <returns>
        /// The ratings to display
        /// </returns>
        [HttpGet("{authorityId}")]
        public async Task<IActionResult> Get(int authorityId)
        {
            var request = new GetLocalAuthorityEstablishmentRatingsRequest(authorityId);
            var result = await _mediator.Send(request);
            return Ok(result.Map());
        }
    }
}