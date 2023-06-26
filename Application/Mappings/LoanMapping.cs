using Application.DomainTransferObjects.LoanDTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings {
    public class LoanMapping : Profile {
        public LoanMapping() { 
            CreateMap<Loan, LoanPostDTO>().ReverseMap();
            CreateMap<Loan, LoanGetDTO>().ReverseMap();
            CreateMap<Loan, LoanUpdateDTO>().ReverseMap();
        }
    }
}
