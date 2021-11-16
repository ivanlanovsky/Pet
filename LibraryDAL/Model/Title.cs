using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryDAL.Model
{
    public partial class Title
    {
        public Title()
        {
            TitleListItems = new HashSet<TitleListItem>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Series { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<TitleListItem> TitleListItems { get; set; }
    }
}
