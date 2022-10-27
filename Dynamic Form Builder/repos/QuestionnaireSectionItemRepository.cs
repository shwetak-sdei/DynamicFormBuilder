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
    public class QuestionnaireSectionItemRepository : RepositoryBase<DFA_SectionItem>, IQuestionnaireSectionItemRepository
    {
        private HCOrganizationContext _context;
        public QuestionnaireSectionItemRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }

        public SectionItemlistingModel GetSectionItems(SectionFilterModel sectionFilterModel, TokenModel tokenModel)
        {
            SqlParameter[] parameters = {new SqlParameter("@DocumentId",sectionFilterModel.DocumentId),
                                          new SqlParameter("@PageNumber", sectionFilterModel.pageNumber),
                                          new SqlParameter("@PageSize", sectionFilterModel.pageSize),
                                          new SqlParameter("@SortColumn",sectionFilterModel.sortColumn),
                                          new SqlParameter("@SortOrder",sectionFilterModel.sortOrder),
                                          new SqlParameter("@OrganizationId", tokenModel.OrganizationID),};
            return _context.ExecStoredProcedureListWithOutputForSectionItems(SQLObjects.DFA_GetSectionItems.ToString(), parameters.Length, parameters);
        }

        public SectionItemlistingModel GetSectionItemsForForm(int DocumentId, TokenModel tokenModel)
        {
            SqlParameter[] parameters = {new SqlParameter("@DocumentId",DocumentId),                                          
                                          new SqlParameter("@OrganizationId", tokenModel.OrganizationID),};
            return _context.ExecStoredProcedureListWithOutputForSectionItems(SQLObjects.DFA_GetSectionItemsForForm.ToString(), parameters.Length, parameters);
        }

        public SectionItemDDValueModel GetSectionItemDDValues(SectionFilterModel sectionFilterModel, TokenModel tokenModel)
        {
            SqlParameter[] parameters = {new SqlParameter("@DocumentId",sectionFilterModel.DocumentId),
                                          new SqlParameter("@OrganizationId", tokenModel.OrganizationID),};
            return _context.ExecStoredProcedureListWithOutputForSectionItemDDValues(SQLObjects.DFA_GetSectionItemDDValues.ToString(), parameters.Length, parameters);
        }

        public IQueryable<T> GetSectionItemsByID<T>(int id, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = { new SqlParameter("@SectionItemId", id) };
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_GetSectionItemsByID.ToString(), parameters.Length, parameters).AsQueryable();
        }
    }
}
