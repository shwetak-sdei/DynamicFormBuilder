using HC.Model;
using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Model.Questionnaire;
using HC.Patient.Repositories.IRepositories.Questionnaire;
using HC.Repositories;
using System.Data.SqlClient;
using System.Linq;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Repositories.Repositories.Questionnaire
{
    public class DocumentAnswerRepository : RepositoryBase<DFA_DocumentAnswer>, IDocumentAnswerRepository
    {
        private HCOrganizationContext _context;
        public DocumentAnswerRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }

        public IQueryable<T> SaveQuestionAnswer<T>(AnswersModel answersModel, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = {new SqlParameter("@Data",answersModel.questionAnswerXML.ToString()),
                                         new SqlParameter("@PatientId", answersModel.PatientID),
                                         new SqlParameter("@UserId", tokenModel.UserID),
                                         new SqlParameter("@DocumentId", answersModel.DocumentId),
                                         new SqlParameter("@PatientDocumentId", answersModel.PatientDocumentId)
                                          };
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_SaveAnswers.ToString(), parameters.Length, parameters).AsQueryable();
        }

        public AnswersModel GetPatientAnswer(PatientDocumentAnswerFilterModel patientDocumentFilterModel, TokenModel tokenModel)
        {
            SqlParameter[] parameters = { new SqlParameter("@DocumentId",patientDocumentFilterModel.DocumentId),
                                          new SqlParameter("@PatientDocumentId",patientDocumentFilterModel.PatientDocumentId),
                                          new SqlParameter("@PatientId",patientDocumentFilterModel.PatientId),                                          
                                          new SqlParameter("@OrganizationId", tokenModel.OrganizationID),};
            return _context.ExecStoredProcedureGetPatientDocumentAnswer(SQLObjects.DFA_GetPatientDocumentAnswer.ToString(), parameters.Length, parameters);
        }
    }
}
