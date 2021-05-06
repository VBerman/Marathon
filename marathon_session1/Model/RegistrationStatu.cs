namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistrationStatu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte RegistrationStatusId { get; set; }

        [Required]
        [StringLength(80)]
        public string RegistrationStatus { get; set; }
    }
}
