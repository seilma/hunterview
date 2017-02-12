using Data.Infrastructure;
using Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSpecifique
{
    public class ServiceSpecialy : Service<Speciality>, ISpecialitySpec 
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);
        public ServiceSpecialy() : base(uof)
        {

        }

        public IEnumerable<Speciality> GetSpecialityByExperienceNote(Experience e)
        {
            IEnumerable<Experience> ls = uof.GetRepository<Experience>().GetMany(p => p.Note == e.Note);
            List<Speciality> lsp = new List<Speciality>();
            foreach (var item in ls)
            {
                lsp.Add(item.Speciality);
            }
            return lsp;
        }

        public IEnumerable<Speciality> GetSpecialityByHeadhunterJob(HeadHunter h)
        {
            IEnumerable<Job> lj = uof.GetRepository<Job>().GetMany(p => p.Headhunter == h);
            List<Speciality> ls = new List<Speciality>();
            foreach (var item in lj)
            {

                ls.AddRange(item.Specialities);
            }

            return ls.Distinct();
        }

        public IEnumerable<Speciality> GetSpecialityByUser(User u)
        {

        }
        public IEnumerable<Speciality> GetSpecialityByTitle(Speciality s)
        {
            return GetMany(p=>p.Title == s.Title);
        }
        public IEnumerable<Speciality> GetSpecialityBySector(Sector s)
        {
            return GetMany(p => p.Sector == s);
        }
        public IEnumerable<Speciality> GetSpecialityByJob(Job j)
        {
            return j.Specialities;
        }
        public Speciality GetSpecialityByQuestion(Question q)
        {
            return q.Speciality;
        }
    }
}
