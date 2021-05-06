namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RaceKitOption")]
    public partial class RaceKitOption
    {
        [StringLength(1)]
        public string RaceKitOptionId { get; set; }

        [Column("RaceKitOption")]
        [Required]
        [StringLength(80)]
        public string RaceKitOption1 { get; set; }

        public decimal Cost { get; set; }
    }
}
