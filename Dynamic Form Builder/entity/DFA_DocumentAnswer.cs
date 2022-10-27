using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HC.Patient.Entity
{
    public class DFA_DocumentAnswer : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; } //Document related to patient        

        [ForeignKey("DFA_PatientDocuments")]
        public int PatientDocumentId { get; set; } //Answer reted to document
        

        [ForeignKey("DFA_SectionItem")]
        public int SectionItemId { get; set; } //Question Id from section item table

        [ForeignKey("DFA_CategoryCode")]
        public Nullable<int> AnswerId { get; set; } //foreign key from DFA_CategoryCode

        public string TextAnswer { get; set; }

        //Foreign key's tables        
        public virtual Patients Patient { get; set; }
        public virtual DFA_PatientDocuments DFA_PatientDocuments { get; set; }
        public virtual DFA_SectionItem DFA_SectionItem { get; set; }
        public virtual DFA_CategoryCode DFA_CategoryCode { get; set; }
    }
}
