using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LibraryDAL.Model
{
    public partial class TitleList
    {
        public TitleList()
        {
            TitleListItems = new HashSet<TitleListItem>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public int ListTypeId { get; set; }

        public virtual ListType ListType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TitleListItem> TitleListItems { get; set; }
    }
}
