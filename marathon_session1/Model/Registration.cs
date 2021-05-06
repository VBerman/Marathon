namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    public partial class Registration
    {
        public int RegistrationId { get; set; }

        public int RunnerId { get; set; }

        public DateTime RegistrationDateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string RaceKitOptionId { get; set; }

        public byte RegistrationStatusId { get; set; }

        public decimal Cost { get; set; }

        public int CharityId { get; set; }

        public decimal SponsorshipTarget { get; set; }
    }
}
