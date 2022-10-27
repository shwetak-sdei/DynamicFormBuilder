using HC.Patient.Model.Common;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HC.Patient.Model.Questionnaire
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }                
        public decimal? PerfectScore { get; set; }
        public int[] HRACategoryRiskIds { get; set; }
        public int? DisplayOrder { get; set; }
        public decimal TotalRecords { get; set; }
    }    

    public class CategoryCodeModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public decimal Score { get; set; }
        public decimal TotalRecords { get; set; }
    }

    public class QuestionnaireDocumentModel
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public int? DocumenttypeId { get; set; }
        public int MasterAssessmentTypeId { get; set; }
        public decimal TotalRecords { get; set; }
        public List<BenchmarkRangeModel> BenchmarkRangeModel { get; set; }
    }
    public class BenchmarkRangeModel
    {
        public int Id { get; set; }
        public int BenchmarkId { get; set; }
        public decimal MinRange { get; set; }
        public decimal MaxRange { get; set; }
        public int QuestionnaireId { get; set; }

    }
    public class QuestionnaireTypeModel
    {
        public int Id { get; set; }
        public string AssessmentName { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }
    }
    public class QuestionnaireSectionModel
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string SectionName { get; set; }
        public int? DisplayOrder { get; set; }
        public int? HRAGenderCriteria { get; set; }
        public decimal TotalRecords { get; set; }
    }

    public class QuestionnaireSectionItemModel
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int SectionId { get; set; }
        public int Itemtype { get; set; }//type of the question like textbox or radiobutton etc.
        public string ItemLabel { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? IsNumber { get; set; }
        public string Placeholder { get; set; }
    }


    #region Section Item model
    public class SectionItemlistingModel
    {
        public List<SectionItemModel> SectionItems { get; set; }
        public List<CodeModel> Codes { get; set; }
    }

    public class SectionItemModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string SectionName { get; set; }
        public string InputType { get; set; }
        public string Question { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? IsNumber { get; set; }
        public string Placeholder { get; set; }
        public decimal TotalRecords { get; set; }
    }

    public class CodeModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Option { get; set; }        
        public int? DisplayOrder { get; set; }
    }

    public class SectionItemDDValueModel
    {
        public List<MasterDropDown> SectionItems { get; set; }
        public List<MasterDropDown> ControlTypes { get; set; }
    }
    #endregion

    #region Answer
    public class AnswersModel
    {
        public int PatientID { get; set; } //Document related to patient
        public int DocumentId { get; set; } //Answer reted to document
        public int PatientDocumentId { get; set; }
        public List<SectionItemModel> SectionItems { get; set; }
        public List<CodeModel> Codes { get; set; }
        public List<AnswerModel> Answer { get; set; }
        public List<DocumentSignatureModel> DocumentSignature { get; set; }
        //for parse Answer model to xml
        public XElement questionAnswerXML { get; set; }
    }
    public class AnswerModel
    {   
        public int Id { get; set; }       
        public int SectionItemId { get; set; } //Question Id from section item table
        public Nullable<int> AnswerId { get; set; } = 0; //foreign key from DFA_CategoryCode
        public string TextAnswer { get; set; }
    }

    public class DocumentSignatureModel
    {
        public int PatientDocumentId { get; set; }
        public byte[] PatientSign { get; set; }
        public byte[] ClinicianSign { get; set; }
        public string Status { get; set; }
    }
    #endregion

    #region Patient Documents

    public class PatientDocumentModel
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int StatusId { get; set; }
        public string DocumentName { get; set; }
        public string PatientName { get; set; }
        public int PatientId { get; set; }
        public string AssignedBy { get; set; }
        public string Status { get; set; }
        public decimal? QScore { get; set; }
        public string Risk { get; set; }
        public string ReportName { get; set; }
        public int DocumenttypeId { get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal TotalRecords { get; set; }
        public bool? IsDocumentAttached {get; set;}
    }
    public class AssignDocumentToPatientModel
    {   
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DocumentId { get; set; }        
        public int AssignedBy { get; set; }
        public string PatientName { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public  DateTime? AssignedDate { get; set; }
        public int LinkedEncounterId { get; set; }
    }
    public class AssignDocumentToMultiplePatientModel
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DocumentId { get; set; }
        public int AssignedBy { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? AssignedDate { get; set; }
    }
    public class SaveSignatureModel
    {
        public int PatientDocumentId { get; set; }
        public byte[] PatientSign { get; set; } = null;
        public byte[] ClinicianSign { get; set; } = null;
    }
    #endregion

}
