using HC.Model;
using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Repositories.IRepositories.Questionnaire;
using HC.Repositories;
using System.Data.SqlClient;
using System.Linq;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Repositories.Repositories.Questionnaire
{
    public class PatientDocumentsRepository : RepositoryBase<DFA_PatientDocuments>, IPatientDocumentsRepository
    {
        private HCOrganizationContext _context;
        public PatientDocumentsRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }

        public IQueryable<T> GetPatientDocuments<T>(PatientDocumentFilterModel patientDocumentFilterModel, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = {new SqlParameter("@PatientId",patientDocumentFilterModel.PatientId),
                                         new SqlParameter("@DocumentId",patientDocumentFilterModel.DocumentId),
                                         new SqlParameter("@Status",patientDocumentFilterModel.Status),
                                         new SqlParameter("@SearchText",patientDocumentFilterModel.SearchText),
                                         new SqlParameter("@PageNumber", patientDocumentFilterModel.pageNumber),
                                         new SqlParameter("@PageSize", patientDocumentFilterModel.pageSize),
                                         new SqlParameter("@SortColumn",patientDocumentFilterModel.sortColumn),
                                         new SqlParameter("@SortOrder",patientDocumentFilterModel.sortOrder),
                                         new SqlParameter("@UserId",tokenModel.UserID),
                                         new SqlParameter("@OrganizationId", tokenModel.OrganizationID)};
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_GetPatientDocuments.ToString(), parameters.Length, parameters).AsQueryable();
        }
        public IQueryable<T> GetPatientDocumentDetails<T>(int Id, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = {new SqlParameter("@Id", Id),
                                         new SqlParameter("@UserId",tokenModel.UserID),
                                         new SqlParameter("@OrganizationId", tokenModel.OrganizationID)};
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_GetPatientDocumentDetails.ToString(), parameters.Length, parameters).AsQueryable();
        }
    }
}
