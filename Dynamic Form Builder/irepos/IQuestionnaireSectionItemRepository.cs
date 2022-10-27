using HC.Model;
using HC.Patient.Entity;
using HC.Patient.Model.Questionnaire;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HC.Patient.Repositories.IRepositories.Questionnaire
{
    public interface IQuestionnaireSectionItemRepository : IRepositoryBase<DFA_SectionItem>
    {
        SectionItemlistingModel GetSectionItems(SectionFilterModel sectionFilterModel, TokenModel tokenModel);
        SectionItemlistingModel GetSectionItemsForForm(int DocumentId, TokenModel tokenModel);
        SectionItemDDValueModel GetSectionItemDDValues(SectionFilterModel sectionFilterModel, TokenModel tokenModel);
        IQueryable<T> GetSectionItemsByID<T>(int id, TokenModel tokenModel) where T : class, new();
    }
}
