using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryDAL.Model
{
    public partial class User
    {
        public User()
        {
            TitleLists = new HashSet<TitleList>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TitleList> TitleLists { get; set; }
    }
}
