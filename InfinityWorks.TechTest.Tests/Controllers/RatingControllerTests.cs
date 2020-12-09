namespace InfinityWorks.TechTest.Test.Controllers
{
    using Dtos = InfinityWorks.TechTest.Api.Dtos;
    using InfinityWorks.TechTest.Api.Controllers;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using NSubstitute;
    using MediatR;
    using InfinityWorks.TechTest.Core.Features.GetLocalAuthorities;
    using InfinityWorks.TechTest.Core.Domain;
    using Microsoft.AspNetCore.Mvc;

    class RatingControllerTests
    {
        [Test]
        public async Task GetAuthoritiesTest()
        {
            var mediatr = Substitute.For<IMediator>();
            var response = new GetLocalAuthoritiesResponse(new[]
            { 
                new LocalAuthority(1, "authority1"),
                new LocalAuthority(2, "authority2"),
            });
            
            mediatr.Send(Arg.Any<GetLocalAuthoritiesRequest>()).Returns(response);

            var sut = new RatingController(mediatr);
            var controllerResponse = await sut.GetAsync();

            Assert.IsInstanceOf<OkObjectResult>(controllerResponse);

            var okResult = controllerResponse as OkObjectResult;
            var authorities = okResult.Value as IEnumerable<Dtos.Authority>;
            Assert.AreEqual(authorities.Count(), 2);
            Assert.AreEqual(authorities.First().Name, "authority1");
            Assert.AreEqual(authorities.First().Id, 1);
            Assert.AreEqual(authorities.Last().Name, "authority2");
            Assert.AreEqual(authorities.Last().Id, 2);
        }
    }
}
