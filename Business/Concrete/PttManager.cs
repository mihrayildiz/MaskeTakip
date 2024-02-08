using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public  class PttManager :ISupplierService
    {
        //dependency injection
        private IApplicantService _applicantService; //global alana tanımlanmış bir değişken aslında
        public PttManager(IApplicantService applicantService) //constructor new yapıldığında çalışır.
        {
            _applicantService = applicantService; //applicantService e bağımlığım demekyir.
        }

      
        public void GiveMask(Person person)
        {
            if( _applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }

        //public void GiveMask(Person person)
        //{
        //    PersonManager personManager = new PersonManager();
        //    if(personManager.CheckPerson(person))
        //    {
        //        Console.WriteLine(person.FirstName + "için mase verildi.");
        //    }
        //}
        //bir uygulama da eğer ki businss classı birbirine bu ekilde bağlaysa yani bir lass diğer classı kullanıyorsa uygulama direnç gösterir. bu ne demektir?
        //diyelim ki yabancı vatandaşlara maske verilmek itenirse; bu kısım çalışmak zoruna çünkü her şey personmanagerada bağlı

    }

}


//şu an sadece ptt manager üzerinden maske verildiğini düşündük ancak eczane üzerinden de dağıtım yapılabilseydi bu sebeple ISupplierService interfacei de tanımlandı. 