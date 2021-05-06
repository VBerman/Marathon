namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Charity")]
    public partial class Charity
    {
        public int CharityId { get; set; }

        [Required]
        [StringLength(100)]
        public string CharityName { get; set; }

        [StringLength(2000)]
        public string CharityDescription { get; set; }

        [StringLength(50)]
        public string CharityLogo { get; set; }
    }
}
