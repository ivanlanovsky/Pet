using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDAL.Model
{
    public partial class Title
    {
        public Title()
        {
            TitleListItems = new HashSet<TitleListItem>();
        }

        public int IdTitle { get; set; }
        public string Name { get; set; }
        public int? Series { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<TitleListItem> TitleListItems { get; set; }
    }
}
