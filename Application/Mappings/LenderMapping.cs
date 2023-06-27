using Application.DomainTransferObjects.LenderDTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings {
    public class LenderMapping : Profile {
        public LenderMapping() { 
            CreateMap<Lender, LenderGetDTO>().ReverseMap();
            CreateMap<Lender, LenderPostDTO>().ReverseMap();
            CreateMap<Lender, LenderUpdateDTO>().ReverseMap();
        }
    }
}
