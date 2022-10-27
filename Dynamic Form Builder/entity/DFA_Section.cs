using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_Section : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("DFA_Document")]
        public int DocumentId { get; set; }
        public string SectionName { get; set; }        
        public int? DisplayOrder { get; set; }
        [ForeignKey("GlobalCode")]
        public int? HRAGenderCriteria { get; set; }
        public virtual DFA_Document DFA_Document { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
    }
}
