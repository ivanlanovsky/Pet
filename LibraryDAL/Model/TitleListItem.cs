using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDAL.Model
{
    public partial class TitleListItem
    {
        public int IdTitleListItem { get; set; }
        public int TitleId { get; set; }
        public int TitleListId { get; set; }

        public virtual Title Title { get; set; }
        public virtual TitleList TitleList { get; set; }
    }
}
