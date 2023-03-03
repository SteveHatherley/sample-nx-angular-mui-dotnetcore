using Microsoft.AspNetCore.Mvc;

namespace Init.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CountdownController : ControllerBase
{
        private static Countdown[] Countdowns = new[]
        {
            new Countdown{
                Id = Guid.NewGuid(),
                Name = "First Contact Day",
                StartTime = DateTime.Now,
                EndTime = new DateTime(2063,04,05,21,15,00,0000)
            },
            new Countdown{
                Id = Guid.NewGuid(),
                Name = "30 Seconds from DateTime.Now",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddSeconds(30)
            },
            new Countdown{
                Id = Guid.NewGuid(),
                Name = "5 Minutes from DateTime.Now",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddMinutes(5)
            },
            new Countdown{
                Id = Guid.NewGuid(),
                Name = "30 Days from DateTime.Now",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(30)
            }
        };

        [HttpGet(Name = "GetCountdowns")]
        public IEnumerable<Countdown> Get() {
            return Countdowns;
        }
}