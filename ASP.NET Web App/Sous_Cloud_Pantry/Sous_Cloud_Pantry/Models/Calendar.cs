﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.Models
{
    public partial class Calendar
    {
        public int? UserId { get; set; }
        public DateTime? CalendarDay { get; set; }
        public DateTime? CalendarMonth { get; set; }
        public DateTime? CalendarYear { get; set; }
    }
}
