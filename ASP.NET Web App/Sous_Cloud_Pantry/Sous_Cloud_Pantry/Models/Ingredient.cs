using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.Models
{
    public partial class Ingredient
    {
        public string IngredientName { get; set; }
        public int? MeasurementId { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
