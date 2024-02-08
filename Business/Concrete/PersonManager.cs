using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//servis olarakta geçer
//somut nesneler içindir.
//person classı entities katmanınd bu sebeple using bloğu eklendi.(using Entities.Concrete;)

//maske için başvuru yapan kişiler
namespace Business.Concrete
{
    public  class PersonManager :IApplicantService
    {
        //encapsulation 
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) // kişi doğru mu kısacası bir vatatandaş mı
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, 
                person.FirstName, person.LastName, 
                person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}


//mthod içerisine sıası ile firstname, lastname şekilide teker teker verebilirdim ancak ben bu methou irden fazla yerde kullanıyr olabilirm. bu sebeple
//prop.ları içerisinde barındıran classı vermek daha mantıklı olur. böylece classa bir prop. daha eklense herhangi bir alanda kod içerisnde hata oluşmaz.