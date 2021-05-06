namespace marathon_session1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timesheet")]
    public partial class Timesheet
    {
        [Key]
        [Column(Order = 0)]
        public int TimesheetId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffId { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal? PayAmount { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
