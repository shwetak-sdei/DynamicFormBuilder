using HC.Model;
using HC.Patient.Entity;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HC.Patient.Repositories.IRepositories.Questionnaire
{
    public interface IQuestionnaireCategoryRepository : IRepositoryBase<DFA_Category>
    {
        IQueryable<T> GetCategories<T>(CommonFilterModel categoryFilterModel, TokenModel tokenModel) where T : class, new();
        List<int> GetMasterHRACategoryRisk(int categoryId);
        void Save(DFA_Category dFA_Category, bool IsUpdate);
        void DeleteMasterHRACategoryRiskMapping(int categoryId);
    }
}
