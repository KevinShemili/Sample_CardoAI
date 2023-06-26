using Application.Contracts;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Application.DomainTransferObjects.LoanDTOs;

namespace Sample.Controllers {
    [ApiController]
    [Route("loans")]
    public class LoanController : ControllerBase {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService) {
            _loanService = loanService;
        }

        [HttpGet]
        public ActionResult<LoanGetDTO> GetAllLoans() {
            try {
                var loans = _loanService.GetAllLoans();
                return Ok(loans);
            }
            catch (NoLoansFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateLoan([FromBody] LoanPostDTO loanPostDTO) {

            _loanService.Create(loanPostDTO);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateLoan([FromBody] LoanUpdateDTO loanUpdateDTO) {
            try {
                _loanService.Update(loanUpdateDTO);
                return Ok();
            }
            catch (LoanNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<LoanGetDTO> GetLoanById([FromRoute] int id) {
            try {
                var loan = _loanService.GetById(id);
                return Ok(loan);
            }
            catch (LoanNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLoan([FromRoute] int id) {
            try {
                _loanService.Delete(id);
                return Ok();
            }
            catch (LoanNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }
    }
}
