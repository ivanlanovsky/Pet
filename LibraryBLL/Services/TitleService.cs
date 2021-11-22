using System;
using System.Collections.Generic;
using System.Text;
using LibraryBLL.Dto;
using AutoMapper;
using LibraryDAL.Model;
using LibraryDAL.UoW;

namespace LibraryBLL.Services
{
    public class TitleService: ITitleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TitleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public TitleViewModel GetById(int id)
        {
            Title title = _unitOfWork.Titles.GetById(id);
            if(title == null)
            {
                return null;
            }
            return _mapper.Map<Title, TitleViewModel>(title);
        }

        public IEnumerable<TitleViewModel> GetAllTitles()
        {
            var unmappedTitles = _unitOfWork.Titles.GetAll();

            var mappedTitles = _mapper.Map<IEnumerable<Title>, IEnumerable<TitleViewModel>>(unmappedTitles);

            return mappedTitles;
        }
    }
}
