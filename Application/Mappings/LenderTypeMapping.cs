using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings {
    public class LenderTypeMapping : Profile {
        public LenderTypeMapping() {
            CreateMap<LenderType, LenderTypeGetDTO>().ReverseMap();
            CreateMap<LenderType, LenderTypePostDTO>().ReverseMap();
            CreateMap<LenderType, LenderTypeUpdateDTO>().ReverseMap();
        }
    }
}
