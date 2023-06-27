using Application.Contracts;
using Application.DomainTransferObjects.LenderTypeDTOs;
using Application.DomainTransferObjects;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Application.DomainTransferObjects.LenderTypeLocalizationDTOs;

namespace Sample.Controllers {
    [ApiController]
    [Route("lender-type-localization")]
    public class LenderTypeLocalizationController : ControllerBase {
        private readonly ILenderTypeLocalizationService _lenderTypeLocalizationService;

        public LenderTypeLocalizationController(ILenderTypeLocalizationService lenderTypeLocalizationService) {
            _lenderTypeLocalizationService = lenderTypeLocalizationService;
        }

        [HttpGet]
        public ActionResult<LenderTypeLocalizationGetDTO> GetAllLenderTypeLocalizations() {
            try {
                var localizations = _lenderTypeLocalizationService.GetAllLenderTypeLocalizations();
                return Ok(localizations);
            }
            catch (NoLenderTypeLocalizationsFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateLenderTypeLocalization([FromBody] LenderTypeLocalizationPostDTO lenderTypeLocalizationPostDTO) {
            _lenderTypeLocalizationService.Create(lenderTypeLocalizationPostDTO);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateLenderTypeLocalization([FromBody] LenderTypeLocalizationUpdateDTO lenderTypeLocalizationUpdateDTO) {
            try {
                _lenderTypeLocalizationService.Update(lenderTypeLocalizationUpdateDTO);
                return Ok();
            }
            catch (LenderTypeLocalizationNotFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id}/{cultureId}")]
        public ActionResult<LenderTypeLocalizationGetDTO> GetLenderTypeById([FromRoute] int id, [FromRoute] int cultureId) {
            try {
                var localization = _lenderTypeLocalizationService.GetById(id, cultureId);
                return Ok(localization);
            }
            catch (LenderTypeLocalizationNotFound exception) {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id}/{cultureId}")]
        public ActionResult DeleteLenderType([FromRoute] int id, [FromRoute] int cultureId) {
            try {
                _lenderTypeLocalizationService.Delete(id, cultureId);
                return Ok();
            }
            catch (LenderTypeLocalizationNotFound exception) {
                return NotFound(exception.Message);
            }
        }
    }
}
