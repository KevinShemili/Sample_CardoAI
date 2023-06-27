using Application.DomainTransferObjects.LoanStatusDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings {
    public class LoanStatusMapping : Profile {
        public LoanStatusMapping() {
            CreateMap<LoanStatus, LoanStatusGetDTO>().ReverseMap();
            CreateMap<LoanStatus, LoanStatusPostDTO>().ReverseMap();
            CreateMap<LoanStatus, LoanStatusUpdateDTO>().ReverseMap(); 
        }
    }
}
