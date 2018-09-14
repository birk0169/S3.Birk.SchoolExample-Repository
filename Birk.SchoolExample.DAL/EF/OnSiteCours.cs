namespace Birk.SchoolExample.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OnSiteCourses")]
    public partial class OnSiteCours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string Days { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Time { get; set; }

        public virtual Cours Cours { get; set; }
    }
}
