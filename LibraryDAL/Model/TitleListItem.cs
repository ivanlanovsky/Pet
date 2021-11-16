using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryDAL.Model
{
    public partial class TitleListItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TitleId { get; set; }
        [Required]
        public int TitleListId { get; set; }

        public virtual Title Title { get; set; }
        public virtual TitleList TitleList { get; set; }
    }
}
