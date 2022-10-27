using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_SectionItem : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("DFA_Section")]
        public int SectionId { get; set; }

        [ForeignKey("DFA_CategoryCode")]
        public int Itemtype { get; set; }//type of the question like textbox or radiobutton etc.
                
        public string ItemLabel { get; set; }

        [ForeignKey("DFA_Category")]
        public int? CategoryId { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsMandatory { get; set; }
        public bool? IsNumber { get; set; }
        public string Placeholder { get; set; }
        public virtual DFA_Section DFA_Section { get; set; }
        public virtual DFA_CategoryCode DFA_CategoryCode { get; set; }
        public virtual DFA_Category DFA_Category { get; set; }
    }
}
