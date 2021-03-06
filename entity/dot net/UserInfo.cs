﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Xmu.Crms.Shared.Models
{
    public class UserInfo
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        [ForeignKey("school_id")]
        public School School { get; set; }
        public int Gender { get; set; }
        public int Type { get; set; }
        public string Number { get; set; }
        public int Education { get; set; }
        public int Title { get; set; }
        public string Email { get; set; }
    }
}