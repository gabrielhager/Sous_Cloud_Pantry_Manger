using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPw { get; set; }
        public string EmailAddress { get; set; }
    }
}
