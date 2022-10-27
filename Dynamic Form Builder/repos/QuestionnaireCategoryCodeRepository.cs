using HC.Model;
using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Repositories.IRepositories.Questionnaire;
using HC.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Repositories.Repositories.Questionnaire
{
    public class QuestionnaireCategoryCodeRepository : RepositoryBase<DFA_CategoryCode>, IQuestionnaireCategoryCodeRepository
    {
        private HCOrganizationContext _context;
        public QuestionnaireCategoryCodeRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }
        #region Category Codes
        public IQueryable<T> GetCategoryCodes<T>(CategoryCodesFilterModel categoryCodesFilterModel, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = {new SqlParameter("@SearchText",categoryCodesFilterModel.SearchText),
                                         new SqlParameter("@CategoryId", categoryCodesFilterModel.CategoryId),
                                         new SqlParameter("@PageNumber", categoryCodesFilterModel.pageNumber),
                                         new SqlParameter("@PageSize", categoryCodesFilterModel.pageSize),
                                         new SqlParameter("@SortColumn",categoryCodesFilterModel.sortColumn),
                                         new SqlParameter("@SortOrder",categoryCodesFilterModel.sortOrder) };
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_GetCategoryCodes.ToString(), parameters.Length, parameters).AsQueryable();
        }
        #endregion
    }
}