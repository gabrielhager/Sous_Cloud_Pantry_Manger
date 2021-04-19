using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.models
{
    public partial class Measurement
    {
        public Measurement()
        {
            Ingredients = new HashSet<Ingredient>();
        }

        public int MeasurementId { get; set; }
        public string MeasurementMethod { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
