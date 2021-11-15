using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryDAL.Model
{
    public partial class User
    {
        public User()
        {
            TitleLists = new HashSet<TitleList>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TitleList> TitleLists { get; set; }
    }
}
