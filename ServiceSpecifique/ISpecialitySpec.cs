using Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSpecifique
{
    public interface ISpecialitySpec :IService<Speciality>
    {
         IEnumerable<Speciality> GetSpecialityByHeadhunterJob(HeadHunter h);
         IEnumerable<Speciality> GetSpecialityByExperienceNote(Experience e);
         IEnumerable<Speciality> GetSpecialityByJob(Job j);
         IEnumerable<Speciality> GetSpecialityByUser(User u);
         IEnumerable<Speciality> GetSpecialityBySector(Sector s);
         Speciality GetSpecialityByQuestion(Question q);


    }
}
