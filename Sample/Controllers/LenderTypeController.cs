using Application.Concrete;
using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers {
    [ApiController]
    [Route("lender-types")]
    public class LenderTypeController : ControllerBase {

        private readonly ILenderTypeService _lenderTypeService;

        public LenderTypeController(ILenderTypeService lenderTypeService) {
            _lenderTypeService = lenderTypeService;
        }

        [HttpGet]
        public ActionResult<LenderTypeGetDTO> GetAllLenderTypes() {
            try {
                var lenderTypes = _lenderTypeService.GetAllLenderTypes();
                return Ok(lenderTypes);
            }
            catch (NoLenderTypesFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateLenderType([FromBody] LenderTypePostDTO lenderTypePostDTO) {

            _lenderTypeService.Create(lenderTypePostDTO);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateLenderType([FromBody] LenderTypeUpdateDTO lenderTypeUpdateDTO) {
            try {
                _lenderTypeService.Update(lenderTypeUpdateDTO);
                return Ok();
            }
            catch (LenderTypeNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<LenderTypeGetDTO> GetLenderTypeById([FromRoute] int id) {
            try {
                var lenderType = _lenderTypeService.GetById(id);
                return Ok(lenderType);
            }
            catch (LenderTypeNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLenderType([FromRoute] int id) {
            try {
                _lenderTypeService.Delete(id);
                return Ok();
            }
            catch (LenderTypeNotFoundException exception) {
                return NotFound(exception.Message);
            }
        }
    }
}