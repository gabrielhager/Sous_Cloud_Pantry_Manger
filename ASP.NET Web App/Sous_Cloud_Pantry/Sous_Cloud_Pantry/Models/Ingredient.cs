using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int? MeasurementId { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Measurement Measurement { get; set; }
    }
}
