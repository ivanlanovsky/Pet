using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryDAL.Model
{
    public partial class ListType
    {
        public ListType()
        {
            TitleLists = new HashSet<TitleList>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string ListTypeName { get; set; }

        public virtual ICollection<TitleList> TitleLists { get; set; }
    }
}
