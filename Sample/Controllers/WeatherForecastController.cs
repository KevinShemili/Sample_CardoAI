using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;

namespace Sample.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {

        private readonly ILoanRepository _loanRepository;

        public WeatherForecastController(ILoanRepository loanRepository) {
            _loanRepository = loanRepository;
        }

        [HttpPost(Name = "Test")]
        public IActionResult CreateLoan(Loan loan) {

            _loanRepository.Create(loan);
            return Ok();
        }
    }
}