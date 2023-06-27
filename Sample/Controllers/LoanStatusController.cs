using Application.Contracts;
using Application.DomainTransferObjects.LenderDTO;
using Application.DomainTransferObjects.LoanStatusDTOs;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers {
    [ApiController]
    [Route("loan-status")]
    public class LoanStatusController : ControllerBase {

        private readonly ILoanStatusService _loanStatusService;

        public LoanStatusController(ILoanStatusService loanStatusService) {
            _loanStatusService = loanStatusService;
        }

        [HttpGet]
        public ActionResult<LoanStatusGetDTO> GetAllLoanStatuses() {
            try {
                var loanStatuses = _loanStatusService.GetAllLoanStatuses();
                return Ok(loanStatuses);
            }
            catch (NoLoanStatusesFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateLoanStatus([FromBody] LoanStatusPostDTO loanStatusPostDTO) {

            _loanStatusService.Create(loanStatusPostDTO);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateLoanStatus([FromBody] LoanStatusUpdateDTO loanStatusUpdateDTO) {
            try {
                _loanStatusService.Update(loanStatusUpdateDTO);
                return Ok();
            }
            catch (LoanStatusNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<LenderGetDTO> GetLoanStatusById([FromRoute] int id) {
            try {
                var lender = _loanStatusService.GetById(id);
                return Ok(lender);
            }
            catch (LoanStatusNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLoanStatus([FromRoute] int id) {
            try {
                _loanStatusService.Delete(id);
                return Ok();
            }
            catch (LoanStatusNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }
    }
}
