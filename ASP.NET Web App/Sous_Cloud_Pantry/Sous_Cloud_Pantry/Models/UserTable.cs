using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class UserTable
    {
        public UserTable()
        {
            GroceryLists = new HashSet<GroceryList>();
            Pantries = new HashSet<Pantry>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPw { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<GroceryList> GroceryLists { get; set; }
        public virtual ICollection<Pantry> Pantries { get; set; }
    }
}
