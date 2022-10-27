using HC.Model;
using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Repositories.IRepositories.Questionnaire;
using HC.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static HC.Common.Enums.CommonEnum;

namespace HC.Patient.Repositories.Repositories.Questionnaire
{
    public class QuestionnaireCategoryRepository : RepositoryBase<DFA_Category>, IQuestionnaireCategoryRepository
    {
        private HCOrganizationContext _context;
        public QuestionnaireCategoryRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }

        #region Category
        public IQueryable<T> GetCategories<T>(CommonFilterModel categoryFilterModel, TokenModel tokenModel) where T : class, new()
        {
            SqlParameter[] parameters = {new SqlParameter("@SearchText",categoryFilterModel.SearchText),
                                          new SqlParameter("@PageNumber", categoryFilterModel.pageNumber),
                                          new SqlParameter("@PageSize", categoryFilterModel.pageSize),
                                          new SqlParameter("@OrganizationId", tokenModel.OrganizationID),
                                          new SqlParameter("@SortColumn",categoryFilterModel.sortColumn),
                                          new SqlParameter("@SortOrder",categoryFilterModel.sortOrder) };
            return _context.ExecStoredProcedureListWithOutput<T>(SQLObjects.DFA_GetCategories.ToString(), parameters.Length, parameters).AsQueryable();
        }       
        
        public List<int> GetMasterHRACategoryRisk(int categoryId)
        {
            return _context.MappingHRACategoryRisk.Where(a => a.HRACategoryId == categoryId).Select(a => a.HRACategoryRiskId).ToList();
        }        

        public void Save(DFA_Category dFA_Category,bool IsUpdate)
        {
            if (!IsUpdate)
            {
                _context.DFA_Category.Add(dFA_Category);
            }
            else
            {
                _context.DFA_Category.Update(dFA_Category);
            }
            _context.SaveChanges();
        }
        public void DeleteMasterHRACategoryRiskMapping(int categoryId)
        {
            List<MappingHRACategoryRisk> mappingHRACategoryRisk = _context.MappingHRACategoryRisk.Where(a => a.HRACategoryId == categoryId).ToList();
            if(mappingHRACategoryRisk!=null && mappingHRACategoryRisk.Count > 0)
            {
                _context.RemoveRange(mappingHRACategoryRisk.ToArray());
                _context.SaveChanges();
            }
        }
        #endregion
    }
}