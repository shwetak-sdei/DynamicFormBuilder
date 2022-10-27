using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_CategoryCode : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("DFA_Category")]
        public int CategoryId { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public decimal Score { get; set; }        

        //Forign key
        public virtual DFA_Category DFA_Category { get; set; }
    }
}
