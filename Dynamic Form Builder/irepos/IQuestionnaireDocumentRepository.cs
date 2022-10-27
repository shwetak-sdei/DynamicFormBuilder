using HC.Model;
using HC.Patient.Entity;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HC.Patient.Repositories.IRepositories.Questionnaire
{
    public interface IQuestionnaireDocumentRepository : IRepositoryBase<DFA_Document>
    {
        IQueryable<T> GetDocuments<T>(CommonFilterModel commonFilterModel, TokenModel tokenModel) where T : class, new();
        IQueryable<T> GetQuestionnaireTypes<T>(TokenModel tokenModel) where T : class, new();

    }
}
