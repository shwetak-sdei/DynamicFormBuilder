using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_Document : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        [ForeignKey("DocumentType")]
        public int? DocumenttypeId { get; set; }
        [ForeignKey("MasterAssessmentType")]
        public int MasterAssessmentTypeId { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }
        public virtual DiseaseManagementProgram DocumentType { get; set; }
        public virtual MasterAssessmentType MasterAssessmentType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual List<QuestionnaireBenchmarkRange> QuestionnaireBenchmarkRange { get; set; }
    }
}
