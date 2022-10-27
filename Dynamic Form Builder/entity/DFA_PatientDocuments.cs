using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_PatientDocuments : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        [ForeignKey("GlobalCode")]
        public int Status { get; set; }
        [ForeignKey("Staffs")]
        public int AssignedBy { get; set; }
        public Byte[] PatientSign { get; set; }
        public Byte[] ClinicianSign { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }
        public decimal? QScore { get; set; }
        public bool? IsCareGapFlag { get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        //Foreign keys
        public virtual Patients Patient { get; set; }
        public virtual DFA_Document Document { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
        public virtual Staffs Staffs { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
