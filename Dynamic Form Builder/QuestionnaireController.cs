using HC.Model;
using HC.Patient.Model.Questionnaire;
using HC.Patient.Service.IServices.Questionnaire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HC.Patient.Web.Controllers
{
    [Produces("application/json")]
    [Route("Questionnaire")]
    [Authorize(Roles = "ADMIN, STAFF, CLIENT")]
    public class QuestionnaireController : BaseController
    {
        #region Constructor Method
        private readonly IQuestionnaireService _quesionnaireService;
        public QuestionnaireController(IQuestionnaireService quesionnaireService)
        {
            _quesionnaireService = quesionnaireService;

        }
        #endregion

        #region Class Methods

        #region Category
        /// <summary>
        /// get the list of all categories
        /// </summary>
        /// <param name="categoryFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetCategories")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetCategories(CommonFilterModel categoryFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetCategories(categoryFilterModel, GetToken(HttpContext))));
        }
        
        /// <summary>
        /// get the category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetCategoryById")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetCategoryById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetCategoryById(id, GetToken(HttpContext))));
        }

        /// <summary>
        /// save and update categories
        /// </summary>
        /// <param name="categoryModel"></param>
        /// <returns></returns>
        [HttpPost("SaveCategory")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult SaveCategory([FromBody]CategoryModel categoryModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SaveCategory(categoryModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// delete the category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("DeleteCategory")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult DeleteCategory(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.DeleteCategory(id, GetToken(HttpContext))));
        }
        #endregion

        #region Category Codes 
        /// <summary>
        /// get the listing of category codes
        /// </summary>
        /// <param name="categoryCodesFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetCategoryCodes")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetCategoryCodes(CategoryCodesFilterModel categoryCodesFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetCategoryCodes(categoryCodesFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the category code by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetCategoryCodeById")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetCategoryCodeById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetCategoryCodeById(id, GetToken(HttpContext))));
        }

        /// <summary>
        /// save and update category code
        /// </summary>
        /// <param name="categoryCodeModel"></param>
        /// <returns></returns>
        [HttpPost("SaveCategoryCodes")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult SaveCategoryCodes([FromBody]CategoryCodeModel categoryCodeModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SaveCategoryCodes(categoryCodeModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// delete the category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("DeleteCategoryCode")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult DeleteCategoryCode(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.DeleteCategoryCode(id, GetToken(HttpContext))));
        }
        #endregion

        #region Documents
        /// <summary>
        /// get the list of all documents
        /// </summary>
        /// <param name="commonFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetDocuments")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetDocuments(CommonFilterModel commonFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetDocuments(commonFilterModel, GetToken(HttpContext))));
        }
        /// <summary>
        /// get the list of all questionnaire types
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetQuestionnaireTypes")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetQuestionnaireTypes()
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetQuestionnaireTypes(GetToken(HttpContext))));
        }

        /// <summary>
        /// get the document by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetDocumentById")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetDocumentById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetDocumentById(id, GetToken(HttpContext))));
        }

        /// <summary>
        /// save and update documents
        /// </summary>
        /// <param name="questionnaireDocumentModel"></param>
        /// <returns></returns>
        [HttpPost("SaveDocument")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult SaveDocument([FromBody]QuestionnaireDocumentModel questionnaireDocumentModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SaveDocument(questionnaireDocumentModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// delete the document by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("DeleteDocument")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult DeleteDocument(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.DeleteDocument(id, GetToken(HttpContext))));
        }
        #endregion

        #region Section
        /// <summary>
        /// get the list of all section
        /// </summary>
        /// <param name="sectionFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetSections")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSections(SectionFilterModel sectionFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSections(sectionFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the section by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetSectionById")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSectionById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSectionById(id, GetToken(HttpContext))));
        }

        /// <summary>
        /// save and update section
        /// </summary>
        /// <param name="questionnaireSectionModel"></param>
        /// <returns></returns>
        [HttpPost("SaveSection")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult SaveSection([FromBody]QuestionnaireSectionModel questionnaireSectionModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SaveSection(questionnaireSectionModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// delete the section by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("DeleteSection")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult DeleteSection(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.DeleteSection(id, GetToken(HttpContext))));
        }
        #endregion

        #region Section Item        
        /// <summary>
        /// save and update section item
        /// </summary>
        /// <param name="questionnaireSectionItemModel"></param>
        /// <returns></returns>
        [HttpPost("SaveSectionItem")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult SaveSectionItem([FromBody]QuestionnaireSectionItemModel questionnaireSectionItemModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SaveSectionItem(questionnaireSectionItemModel, GetToken(HttpContext))));
        }

        [HttpPatch("deleteSectionItem")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult DeleteSectionItem(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.DeleteSectionItem(id, GetToken(HttpContext))));
        }
        /// <summary>
        /// get the list of all section items
        /// </summary>
        /// <param name="sectionFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetSectionItems")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSectionItems(SectionFilterModel sectionFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSectionItem(sectionFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the list of all section items for form
        /// </summary>
        /// <param name="DocumentId"></param>
        /// <returns></returns>
        [HttpGet("GetSectionItemsForForm")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSectionItemsForForm(int DocumentId)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSectionItemsForForm(DocumentId, GetToken(HttpContext))));
        }


        /// <summary>
        /// get the dropdown values
        /// </summary>
        /// <param name="sectionFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetSectionItemDDValues")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSectionItemDDValues(SectionFilterModel sectionFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSectionItemDDValues(sectionFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the section item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetSectionItemById")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult GetSectionItemById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetSectionItemById(id, GetToken(HttpContext))));
        }
        #endregion

        #region Patient Question Answer
        /// <summary>
        /// save question answer
        /// </summary>
        /// <param name="answersModel"></param>
        /// <returns></returns>
        [HttpPost("SavePatientDocumentAnswer")]
        [Authorize(Roles = "ADMIN, STAFF, CLIENT")]
        public JsonResult SavePatientDocumentAnswer([FromBody]AnswersModel answersModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.SavePatientDocumentAnswer(answersModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the patient document with answer
        /// </summary>
        /// <param name="patientDocumentFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetPatientDocumentAnswer")]
        [Authorize(Roles = "ADMIN, STAFF, CLIENT")]
        public JsonResult GetPatientDocumentAnswer(PatientDocumentAnswerFilterModel patientDocumentFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetPatientDocumentAnswer(patientDocumentFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// get the patient documents
        /// </summary>
        /// <param name="patientDocumentFilterModel"></param>
        /// <returns></returns>
        [HttpGet("GetPatientDocuments")]
        [Authorize(Roles = "ADMIN, STAFF, CLIENT")]
        public JsonResult GetPatientDocuments(PatientDocumentFilterModel patientDocumentFilterModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetPatientDocuments(patientDocumentFilterModel, GetToken(HttpContext))));
        }

        /// <summary>
        /// save question answer
        /// </summary>
        /// <param name="assignDocumentToPatientModel"></param>
        /// <returns></returns>
        [HttpPost("AssignDocumentToPatient")]
        [Authorize(Roles = "ADMIN, STAFF")]

        public JsonResult AssignDocumentToPatient([FromBody]AssignDocumentToPatientModel assignDocumentToPatientModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.AssignDocumentToPatient(assignDocumentToPatientModel, GetToken(HttpContext))));
        }
        /// <summary>
        /// save question answer
        /// </summary>
        /// <param name="assignDocumentToPatientModel"></param>
        /// <returns></returns>
        [HttpPost("AssignDocumentToMultiplePatient")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult AssignDocumentToMultiplePatient([FromBody]List<AssignDocumentToMultiplePatientModel> assignDocumentToPatientModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.AssignDocumentToMultiplePatient(assignDocumentToPatientModel, GetToken(HttpContext))));
        }
        /// <summary>
        /// save patient's document 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetPatientDocumentById")]
        public JsonResult GetPatientDocumentById(int id)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.GetPatientDocumentById(id, GetToken(HttpContext))));
        }

        /// <summary>
        /// add signature of client and staff
        /// </summary>
        /// <param name="saveSignatureModel"></param>
        /// <returns></returns>
        [HttpPost("UpdateStatus")]
        [Authorize(Roles = "ADMIN, STAFF")]
        public JsonResult UpdateStatus([FromBody]SaveSignatureModel saveSignatureModel)
        {
            return Json(_quesionnaireService.ExecuteFunctions(() => _quesionnaireService.UpdateStatus(saveSignatureModel, GetToken(HttpContext))));
        }
        #endregion

        #endregion

        #region Helping Methods
        #endregion
    }
}