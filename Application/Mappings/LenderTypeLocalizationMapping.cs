using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeLocalizationDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings {
    public class LenderTypeLocalizationMapping : Profile {
        public LenderTypeLocalizationMapping() {
            CreateMap<LenderTypeLocalization, LenderTypeLocalizationGetDTO>().ReverseMap();
            CreateMap<LenderTypeLocalization, LenderTypeLocalizationPostDTO>().ReverseMap();
            CreateMap<LenderTypeLocalization, LenderTypeLocalizationUpdateDTO>().ReverseMap();
        }
    }
}
