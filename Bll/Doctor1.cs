using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public class Doctor1
    {
        DoctorsDto d;
        PatientsDto p;
        Patient pa = new Patient();
        //OritProjectGoodLuckEntities2 db;

        public OritProjectGoodLuckEntities2 db = OritProjectGoodLuckEntities2.Instance();
        //מקבל את העיר של מיקום מסוים מגוגל מפס לפי האיקס והוואי שאני שולחת
        public String GetCityFromMaps(Location l)
        {
            return "בני ברק";
        }
        //מציאת מחסן באותה עיר שהרופא גר
        public Location Find(List<Location> list, Location locationOfDoctor)
        {
            string nameCityOfStorage, nameCityOfDoctor = GetCityFromMaps(locationOfDoctor);
            foreach (Location item in list)
            {
                nameCityOfStorage = GetCityFromMaps(item);
                if (nameCityOfStorage == nameCityOfDoctor)
                    return item;
            }
            return null;
        }
        public Location FindNereastStorage(Location l)
        {
            List<Location> listLocations = new List<Location>();
            List<Storage> listStorages = db.Storage.ToList();
            foreach (Storage item in listStorages)
            {
                listLocations.Add(db.Location.Where(x => x.locationId == item.locationId).FirstOrDefault());
            }
            //החזרת הלוקיישן מרשימת הלוקיישינים שהכי קרוב ללוקישן שקיבלתי
            Location sofi = Find(listLocations, l);
            return sofi;
        }
        //בונה רשימת לוקישנים לכל רופא של כל המטופלים שהוא מבקר אצלם במשמרת,כשבהתחלה ובסוף יש את הכתובת של המחסן הקרוב לכתובת שלו
        public List<Location> BuildListOfLocationsForDoctor(int idDoctor)
        {
           
                Doctor d = db.Doctor.Where(x => x.id == idDoctor).FirstOrDefault();
                     if(d==null)
                throw new noIdExists(idDoctor);
                Location location = db.Location.Where(x => x.locationId == d.location).FirstOrDefault();
                List<Patient> listPatients = db.Patient.Where(x => x.doctorId == idDoctor).ToList();
                List<Location> listLocation = new List<Location>();
                listLocation.Add(FindNereastStorage(location));
                //מקום ראשון ברשימה אני  מכניסה את המחסן שנמצא הכי קרוב לרופא,ומקום אחרון את הכתובת שלו
                foreach (Patient item in listPatients)
                {
                    Location l = db.Location.Where(x => x.locationId == item.locationId).FirstOrDefault();
                    listLocation.Add(l);
                }
                  listLocation.Add(FindNereastStorage(location));
                         return listLocation;
            }

        //מקבל מגוגל מפס אורך קשת וזמן,ומשקלל את זה למשקל קשת
        public double GetWighetOfEdjeOfTwoPointsFromGoogleMaps(Location location1, Location location2)
        {
            //שליחה לממשק של גוגל מפס את שתי הלוקישנים שקיבלתי וקבלת משקל הקשת של הדרך בין שתיהם לפי נסיעה על כביש
            return 12.0; 
        }
        //פעולה שבונה את מטריצת המרחקים , מחשבת עבור כל  נקודה את המשקל לכל הנקודות שקיימות
        public double[,] BuildMatrixOfDistance(int idDoctor)
        {
            DailyReportToDoctor d = db.DailyReportToDoctor.Where(x => x.idDoctor == idDoctor).FirstOrDefault();
            List<Location> listlocations = BuildListOfLocationsForDoctor(idDoctor);
            int sizeofmatrix = listlocations.Count;
            double[,] matrix = new double[sizeofmatrix, sizeofmatrix]; 
            int i = 0, j = 0;
            foreach (Location item in listlocations)
            {
                foreach (Location item2 in listlocations)
                {
                     matrix[i,j]= GetWighetOfEdjeOfTwoPointsFromGoogleMaps(item,item2);
                    j++;
                }
                i++;
            }          
            return matrix;       

        }


    }
}

