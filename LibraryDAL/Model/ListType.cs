using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDAL.Model
{
    public partial class ListType
    {
        public ListType()
        {
            TitleLists = new HashSet<TitleList>();
        }

        public int IdListType { get; set; }
        public string ListTypeName { get; set; }

        public virtual ICollection<TitleList> TitleLists { get; set; }
    }
}
