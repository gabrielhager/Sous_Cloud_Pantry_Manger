using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string IngredientList { get; set; }

        public virtual GroceryList IngredientListNavigation { get; set; }
    }
}
