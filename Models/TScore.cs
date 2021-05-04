using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GolfStats.Models
{
    public partial class TScore
    {
        public int Id { get; set; }

        [DisplayName("Hole 1")]
        public int Hole1 { get; set; }
        [DisplayName("Hole 2")]
        public int Hole2 { get; set; }
        [DisplayName("Hole 3")]
        public int Hole3 { get; set; }
        [DisplayName("Hole 4")]
        public int Hole4 { get; set; }
        [DisplayName("Hole 5")]
        public int Hole5 { get; set; }
        [DisplayName("Hole 6")]
        public int Hole6 { get; set; }
        [DisplayName("Hole 7")]
        public int Hole7 { get; set; }
        [DisplayName("Hole 8")]
        public int Hole8 { get; set; }
        [DisplayName("Hole 9")]
        public int Hole9 { get; set; }
        [DisplayName("Hole 10")]
        public int Hole10 { get; set; }
        [DisplayName("Hole 11")]
        public int Hole11 { get; set; }
        [DisplayName("Hole 12")]
        public int Hole12 { get; set; }
        [DisplayName("Hole 13")]
        public int Hole13 { get; set; }
        [DisplayName("Hole 14")]
        public int Hole14 { get; set; }
        [DisplayName("Hole 15")]
        public int Hole15 { get; set; }
        [DisplayName("Hole 16")]
        public int Hole16 { get; set; }
        [DisplayName("Hole 17")]
        public int Hole17 { get; set; }
        [DisplayName("Hole 18")]
        public int Hole18 { get; set; }
        public int Score { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Created { get; set; }
    }
}
