using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;
        
        public PttManager(IApplicantService applicantServicew) // Constructor
        {
            _applicantService = applicantServicew;
        }

        public void GiveMask(Person person) 
        {
            // PersonManager personManager = new PersonManager(); // Bu kullanım gerçekleştirilirse sonrasında kurallar değiştiğinde sorunlara yol açabilir.
            //if (personManager.CheckPerson(person))
            //{
            //    Console.WriteLine(person.FirstName + " için Maske Verildi");
            //}

            // Bu yapı sayesinde hem PersonManager hem de Foreigner Manager kullanabilirsin
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için Maske Verildi");
            }
        }
    }
}
