namespace UsandoEnterpriseLibraryDataTemplate.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [Column(Order = 0)]
        public int ClienteID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string SobreNome { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Nascimento { get; set; }
    }
}
