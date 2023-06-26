using Application.DomainTransferObjects;
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
            CreateMap<LenderType, LenderTypeGetDTO>()
                .ForMember(dest =>
                dest.Id,
                opt => opt.MapFrom(src => src.Id))
            .ForMember(dest =>
                dest.IsDeleted,
                opt => opt.MapFrom(src => src.IsDeleted));

        }
    }
}
