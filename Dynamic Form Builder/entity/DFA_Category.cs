using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.Patient.Entity
{
    public class DFA_Category : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }        
        public decimal? PerfectScore { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationID { get; set; }
        
        public virtual Organization Organization { get; set; }
        public virtual List<MappingHRACategoryRisk> MappingHRACategoryRisks { get; set; }
    }
}
