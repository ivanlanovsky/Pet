using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Dto
{
    public class TitleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Series { get; set; }
        public int? Year { get; set; }
    }
}
