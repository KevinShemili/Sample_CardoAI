using Application.Contracts;
using Application.DomainTransferObjects;
using Application.DomainTransferObjects.LenderTypeLocalizationDTOs;
using Application.DomainTransferObjects.LoanDTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Repository.Concrete;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete {
    public class LenderTypeLocalizationService : ILenderTypeLocalizationService {
        
        private readonly ILenderTypeLocalizationRepository _lenderTypeLocalizationRepository;
        private readonly IMapper _mapper;

        public LenderTypeLocalizationService(IMapper mapper, ILenderTypeLocalizationRepository lenderTypeLocalizationRepository) {
            _mapper = mapper;
            _lenderTypeLocalizationRepository = lenderTypeLocalizationRepository;
        }
        public void Create(LenderTypeLocalizationPostDTO lenderTypeLocalizationPostDTO) {
            var entity = _mapper.Map<LenderTypeLocalization>(lenderTypeLocalizationPostDTO);
            _lenderTypeLocalizationRepository.Create(entity);
        }

        public void Delete(int id, int cultureId) {
            var entity = _lenderTypeLocalizationRepository.GetById(id, cultureId);

            if (entity == null) {
                throw new LenderTypeLocalizationNotFound(id, cultureId);
            }

            _lenderTypeLocalizationRepository.Delete(id, cultureId);
        }

        public IEnumerable<LenderTypeLocalizationGetDTO> GetAllLenderTypeLocalizations() {
            var localizations = _lenderTypeLocalizationRepository.GetAll();

            if (!localizations.Any()) {
                throw new NoLenderTypeLocalizationsFound();
            }

            var localizationsDto = _mapper.Map<IEnumerable<LenderTypeLocalizationGetDTO>>(localizations);

            return localizationsDto;
        }

        public LenderTypeLocalizationGetDTO GetById(int id, int cultureId) {
            var entity = _lenderTypeLocalizationRepository.GetById(id, cultureId);

            if (entity == null) {
                throw new LenderTypeLocalizationNotFound(id, cultureId);
            }

            var entityDTO = _mapper.Map<LenderTypeLocalizationGetDTO>(entity);

            return entityDTO;
        }

        public void Update(LenderTypeLocalizationUpdateDTO lenderTypeLocalizationUpdateDTO) {
            var entity = _lenderTypeLocalizationRepository.GetById(lenderTypeLocalizationUpdateDTO.Id, lenderTypeLocalizationUpdateDTO.CultureId);

            if (entity == null) {
                throw new LenderTypeLocalizationNotFound(lenderTypeLocalizationUpdateDTO.Id, lenderTypeLocalizationUpdateDTO.CultureId);
            }

            _mapper.Map(lenderTypeLocalizationUpdateDTO, entity);
            _lenderTypeLocalizationRepository.Update(entity);
        }
    }
}
