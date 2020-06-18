using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristDB_App.Model;

namespace TuristDB_App
{
    class TouristDbOperations
    {

        TouristDbContext db;
        public TouristDbOperations()
        {
            db = new TouristDbContext();
        }

        public void SetCountryTourist(Tourist tourist, Country country)
        {
            db.Tourists.Where(a => a.Name == tourist.Name && a.Surname == tourist.Surname && a.BirthDate == tourist.BirthDate).SingleOrDefault().Countries.Add(db.Countries.Where(a => a.CountryDescription == country.CountryDescription).FirstOrDefault());
            db.SaveChanges();
        }

        

        public void SetNationality(Nationality nationality)
        {
            Nationality n = db.Nationalities.Where(a => a.NationalityDescription == nationality.NationalityDescription).FirstOrDefault();
            if (n==null)
            {
                db.Nationalities.Add(nationality);
                db.SaveChanges();
            }
            
        }
        public void SetGender(Gender gender)
        {
            Gender g = db.Genders.Where(a => a.GenderDescription == gender.GenderDescription).FirstOrDefault();

            if (g==null)
            {
                db.Genders.Add(gender);
                db.SaveChanges();
            }
            
        }

        public void SetLocation(Location location)
        {
            Location l = db.Locations.Where(a => a.LocationDescription == location.LocationDescription).FirstOrDefault();
            if (l==null)
            {
                db.Locations.Add(location);

                db.SaveChanges();
            }
            
        }
        public void SetGuide(Guide guideInfo)
        {
            Guide g = db.Guides.Where(a => a.Name == guideInfo.Name && a.Surname == guideInfo.Surname && a.PhoneNumber == guideInfo.PhoneNumber).FirstOrDefault();
            if (g==null)
            {
                db.Guides.Add(guideInfo);
                db.SaveChanges();
            }
            
        }
        public void SetTourist(Tourist tourist, Nationality nationality,Gender gender)
        {
            Tourist t = db.Tourists.Where(a => a.Name == tourist.Name & a.Surname == tourist.Surname & a.BirthDate == tourist.BirthDate & a.Nationality.NationalityDescription == nationality.NationalityDescription & a.Gender.GenderDescription==gender.GenderDescription).FirstOrDefault();
            if (t==null)
            {
                t = new Tourist();
                t.Name = tourist.Name;
                t.Surname = tourist.Surname;
                t.BirthDate = tourist.BirthDate;
                t.NationalityID = db.Nationalities.Where(a => a.NationalityDescription == nationality.NationalityDescription).Select(a => a.NationalityID).FirstOrDefault();
                t.GenderID = db.Genders.Where(a => a.GenderDescription == gender.GenderDescription).Select(a => a.GenderID).FirstOrDefault();
                db.Tourists.Add(t);
                db.SaveChanges();
            }
        }

        internal void SetPlan(Location location, Tourist tourist, Guide guide, DateTime datetime)
        {
            Plan p = db.Plans.Where(a => a.ArrivalDateInTurkey == datetime && a.Guide.Name == guide.Name && a.Guide.Surname == guide.Surname && a.Tourist.Name == tourist.Name && a.Tourist.Surname == tourist.Surname && a.Location.LocationDescription== location.LocationDescription).FirstOrDefault();
            if (p==null)
            {
                p = new Plan();
                p.GuideID = db.Guides.Where(a => a.Name == guide.Name && a.Surname == guide.Surname).Select(a=>a.GuideID).FirstOrDefault();
                p.LocationID = db.Locations.Where(a => a.LocationDescription == location.LocationDescription).Select(a => a.LocationID).FirstOrDefault();
                p.TouristID = db.Tourists.Where(a => a.Name == tourist.Name && a.Surname == tourist.Surname && a.BirthDate == tourist.BirthDate).Select(a => a.TouristID).FirstOrDefault();
                p.ArrivalDateInTurkey = datetime;
                db.Plans.Add(p);
                db.SaveChanges();
            }
        }

        public void GetCountry(Country country)
        {
            Country c = db.Countries.Where(a => a.CountryDescription == country.CountryDescription).FirstOrDefault();

            if (c==null)
            {
                db.Countries.Add(country);
                db.SaveChanges();
            }


        }
        















    }
}
