using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class GroceryList
    {
        public GroceryList()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int? UserId { get; set; }
        public string ListItem { get; set; }

        public virtual UserTable User { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
