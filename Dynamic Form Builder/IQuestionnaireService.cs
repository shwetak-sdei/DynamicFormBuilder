using HC.Model;
using HC.Patient.Model.Questionnaire;
using HC.Service.Interfaces;
using System.Collections.Generic;

namespace HC.Patient.Service.IServices.Questionnaire
{
    public interface IQuestionnaireService : IBaseService
    {
        //Category
        JsonModel GetCategories(CommonFilterModel categoryFilterModel, TokenModel tokenModel);
        JsonModel SaveCategory(CategoryModel categoryModel, TokenModel tokenModel);
        JsonModel DeleteCategory(int id, TokenModel tokenModel);
        JsonModel GetCategoryById(int id, TokenModel tokenModel);

        //Category Codes
        JsonModel GetCategoryCodes(CategoryCodesFilterModel categoryCodesFilterModel, TokenModel tokenModel);
        JsonModel SaveCategoryCodes(CategoryCodeModel categoryCodeModel, TokenModel tokenModel);
        JsonModel GetCategoryCodeById(int id, TokenModel tokenModel);
        JsonModel DeleteCategoryCode(int id, TokenModel tokenModel);

        //Documents
        JsonModel GetDocuments(CommonFilterModel commonFilterModel, TokenModel tokenModel);
        JsonModel SaveDocument(QuestionnaireDocumentModel questionnaireDocumentModel, TokenModel tokenModel);
        JsonModel GetDocumentById(int id, TokenModel tokenModel);
        JsonModel DeleteDocument(int id, TokenModel tokenModel);

        //Sections
        JsonModel GetSections(SectionFilterModel sectionFilterModel, TokenModel tokenModel);
        JsonModel SaveSection(QuestionnaireSectionModel questionnaireSectionModel, TokenModel tokenModel);
        JsonModel GetSectionById(int id, TokenModel tokenModel);
        JsonModel DeleteSection(int id, TokenModel tokenModel);

        //Section Items
        JsonModel SaveSectionItem(QuestionnaireSectionItemModel questionnaireSectionItemModel, TokenModel tokenModel);
        JsonModel GetSectionItem(SectionFilterModel sectionFilterModel, TokenModel tokenModel);
        JsonModel GetSectionItemsForForm(int DocumentId, TokenModel tokenModel);
        JsonModel GetSectionItemDDValues(SectionFilterModel sectionFilterModel, TokenModel tokenModel);
        JsonModel GetSectionItemById(int id, TokenModel tokenModel);
        JsonModel DeleteSectionItem(int id, TokenModel tokenModel);

        //Patient Question Answer
        JsonModel SavePatientDocumentAnswer(AnswersModel answersModel, TokenModel tokenModel);
        JsonModel GetPatientDocumentAnswer(PatientDocumentAnswerFilterModel patientDocumentFilterModel, TokenModel tokenModel);
        JsonModel GetPatientDocuments(PatientDocumentFilterModel patientDocumentFilterModel, TokenModel tokenModel);
        JsonModel AssignDocumentToPatient(AssignDocumentToPatientModel assignDocumentToPatientModel, TokenModel tokenModel);
        JsonModel AssignDocumentToMultiplePatient(List<AssignDocumentToMultiplePatientModel> assignDocumentToPatientModel, TokenModel tokenModel);
        JsonModel GetPatientDocumentById(int id, TokenModel tokenModel);
        JsonModel UpdateStatus(SaveSignatureModel saveSignatureModel, TokenModel tokenModel);

        // Get Questionnaire type
        JsonModel GetQuestionnaireTypes(TokenModel tokenModel);
    }
}
