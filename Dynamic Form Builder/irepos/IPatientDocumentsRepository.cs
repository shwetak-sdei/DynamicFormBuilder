using HC.Model;
using HC.Patient.Entity;
using HC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HC.Patient.Repositories.IRepositories.Questionnaire
{
    public interface IPatientDocumentsRepository : IRepositoryBase<DFA_PatientDocuments>
    {
        IQueryable<T> GetPatientDocuments<T>(PatientDocumentFilterModel patientDocumentFilterModel, TokenModel tokenModel) where T : class, new();
        IQueryable<T> GetPatientDocumentDetails<T>(int id, TokenModel tokenModel) where T : class, new();
    }
}
