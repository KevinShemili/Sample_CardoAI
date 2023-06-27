using Application.Contracts;
using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Application.DomainTransferObjects.LenderDTO;

namespace Sample.Controllers {
    [ApiController]
    [Route("lender")]
    public class LenderController : ControllerBase {

        private readonly ILenderService _lenderService;

        public LenderController(ILenderService lenderService) {
            _lenderService = lenderService;
        }

        [HttpGet]
        public ActionResult<LenderGetDTO> GetAllLenders() {
            try {
                var lenders = _lenderService.GetAllLenders();
                return Ok(lenders);
            }
            catch (NoLendersFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateLender([FromBody] LenderPostDTO lenderPostDTO) {

            _lenderService.Create(lenderPostDTO);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateLender([FromBody] LenderUpdateDTO lenderUpdateDTO) {
            try {
                _lenderService.Update(lenderUpdateDTO);
                return Ok();
            }
            catch (LenderNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<LenderGetDTO> GetLenderById([FromRoute] int id) {
            try {
                var lender = _lenderService.GetById(id);
                return Ok(lender);
            }
            catch (LenderNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLender([FromRoute] int id) {
            try {
                _lenderService.Delete(id);
                return Ok();
            }
            catch (LenderNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

    }
}
