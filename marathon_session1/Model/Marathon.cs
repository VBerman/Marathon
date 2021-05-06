namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marathon")]
    public partial class Marathon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte MarathonId { get; set; }

        [Required]
        [StringLength(80)]
        public string MarathonName { get; set; }

        [StringLength(80)]
        public string CityName { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryCode { get; set; }

        public short? YearHeld { get; set; }
    }
}
