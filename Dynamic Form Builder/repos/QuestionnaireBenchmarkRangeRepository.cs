using HC.Patient.Data;
using HC.Patient.Entity;
using HC.Patient.Repositories.IRepositories.Questionnaire;
using HC.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Patient.Repositories.Repositories.Questionnaire
{
    public class QuestionnaireBenchmarkRangeRepository : RepositoryBase<QuestionnaireBenchmarkRange>, IRepositories.Questionnaire.IQuestionnaireBenchmarkRangeRepository
    {
        private HCOrganizationContext _context;
        public QuestionnaireBenchmarkRangeRepository(HCOrganizationContext context) : base(context)
        {
            this._context = context;
        }
    }
}
