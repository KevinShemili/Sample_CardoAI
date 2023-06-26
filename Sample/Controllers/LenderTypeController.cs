using Application.Contracts;
using Application.DomainTransferObjects;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace Sample.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LenderTypeController : ControllerBase {

        private readonly ILenderTypeService _lenderTypeService;

        public LenderTypeController(ILenderTypeService lenderTypeService) {
            _lenderTypeService = lenderTypeService;
        }

        [HttpPost("create-new-lender-type")]
        public ActionResult<LenderType> CreateLenderType(LenderTypePostDTO lenderTypeDto) {

            var lenderTypes = _lenderTypeService.GetAllLenderTypes();

            return Ok(lenderTypes);
        }
    }
}