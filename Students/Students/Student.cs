namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Surname { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        public string TelephoneNo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }
    }
}
