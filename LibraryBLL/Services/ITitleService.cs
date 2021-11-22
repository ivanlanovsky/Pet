using System;
using System.Collections.Generic;
using System.Text;
using LibraryBLL.Dto;

namespace LibraryBLL.Services
{
    public interface ITitleService
    {

        public IEnumerable<TitleViewModel> GetAllTitles();
        public TitleViewModel GetById(int id);
    }
}
