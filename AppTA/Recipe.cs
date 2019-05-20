namespace AppTA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(4000)]
        public string JudulResep { get; set; }

        [Required]
        [StringLength(4000)]
        public string BahanResep { get; set; }

        [Required]
        [StringLength(4000)]
        public string LangkahResep { get; set; }
    }
}
