using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App
{
    public class ReadData
    {
        FileStream fileStream;
        TouristDbOperations dbOperations;
        TouristDbContext dbContext;

        Tourist tourist=new Tourist();
        Gender gender;
        Nationality nationality;
        Country country;
        Guide guide;
        Plan plan=new Plan();
        Location location;
        public ReadData()
        {
            fileStream = new FileStream(@"C:\Users\fsozy\OneDrive\Masaüstü\16.04.20_FatmaSedaOZYURT\TuristDB_App\veriler.txt", FileMode.Open, FileAccess.Read);
            dbOperations = new TouristDbOperations();
            dbContext = new TouristDbContext();
        }
        public void ReadDataOnFile()
        {
            DateTime datetime ;
            StreamReader reader = new StreamReader(fileStream);
            string[] data = reader.ReadToEnd().Split('\n');
            //Country
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');



                country = new Country() { CountryDescription = partialData [5]};
                dbOperations.GetCountry(country);



            }
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');


                nationality = new Nationality() { NationalityDescription = partialData[4] };
                dbOperations.SetNationality(nationality);

            }
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');
                gender = new Gender() { GenderDescription = partialData[2] };
                dbOperations.SetGender(gender);
            }
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');
                location = new Location() { LocationDescription = partialData[10] };
                dbOperations.SetLocation(location);
            }
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');
                guide = new Guide() { Name = partialData[6], Surname = partialData[7], PhoneNumber = partialData[8] };
                
                dbOperations.SetGuide(guide);
            }
            foreach (string item in data)
            {
                string[] partialData = item.Split(';');
                nationality = new Nationality() { NationalityDescription = partialData[4] };
                gender = new Gender() { GenderDescription = partialData[2] };
                tourist = new Tourist{Name = partialData[0],Surname = partialData[1],BirthDate = DateTime.Parse(partialData[3])};
                country = new Country() { CountryDescription = partialData[5] };

                dbOperations.SetTourist(tourist,nationality,gender);
                dbOperations.SetCountryTourist(tourist, country);
            }

            foreach (string item in data)
            {
                string[] partialData = item.Split(';');
                location = new Location() { LocationDescription = partialData[10] };
                tourist = new Tourist { Name = partialData[0], Surname = partialData[1], BirthDate = DateTime.Parse(partialData[3]) };
                guide = new Guide() { Name = partialData[6], Surname = partialData[7], PhoneNumber = partialData[8] };
                datetime = DateTime.Parse(partialData[9]);

                dbOperations.SetPlan(location,tourist,guide,datetime);
            }

        }
           
    }
}
