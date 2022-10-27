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
    public interface IDocumentAnswerRepository : IRepositoryBase<DFA_DocumentAnswer>
    {
        IQueryable<T> SaveQuestionAnswer<T>(AnswersModel answersModel, TokenModel tokenModel) where T : class, new();
        AnswersModel GetPatientAnswer(PatientDocumentAnswerFilterModel patientDocumentFilterModel, TokenModel tokenModel);
    }
}
