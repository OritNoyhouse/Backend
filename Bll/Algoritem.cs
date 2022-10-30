using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public class Algorithem
    {

        public Algorithem()
        {

        }

        HashSet<int> _vertices = new HashSet<int>();
        //מטריצת המשקלים
        double[,] _adjacencyMatrix;
        NewArr[] newArr = new NewArr[1000];
        FinalResault[] finalResault = new FinalResault[1000];
        public OritProjectGoodLuckEntities2 db = OritProjectGoodLuckEntities2.Instance();
        
        //פונקצית התאמה של רופא,המקבלת פציינט ומחזירה את הרופא המתאים לאותו פציינט
        public int MachDoctor(Patient p)
        {
            OrderHomeHospitalization orders;
            int mach = -1;
            List<Patient> patients = new List<Patient>();
            Location location = db.Location.Where(x => x.locationId == p.locationId).FirstOrDefault();
            List<Doctor> doctors = db.Doctor.ToList();
            List<Patient> listPatients = db.Patient.ToList();
            foreach (Doctor item in doctors)
            {
                foreach (Patient item2 in listPatients)
                {
                    patients.Add(db.Patient.Where(x => x.doctorId == item.id).FirstOrDefault());
                }

                orders = db.OrderHomeHospitalization.Where(x => x.idDoctor == item.id && x.idPatient == p.id).FirstOrDefault();
                if (patients == null || patients.Count() < 6)
                {
                    if (item.gender == p.gender)
                        //בדיקה האם הרופא הזה היה אצלו כבר,אז עדיף....
                        if (orders != null)
                            mach = item.id;
                        else
                            mach = item.id;
                    else
                        mach = item.id;

                }

            }
            if (mach == -1)
                foreach (Doctor item in doctors)
                {
                    foreach (Patient item2 in listPatients)
                    {
                        patients.Add(db.Patient.Where(x => x.doctorId == item.id).FirstOrDefault());
                    }

                    if (patients == null || patients.Count() < 6)
                        mach = item.id;
                }


            return mach;
        }


        //בונה רשימת לוקישנים לכל רופא של כל המטופלים שהוא מבקר אצלם במשמרת,
        public List<int> BuildListOfLocationsForDoctor(int idDoctor, int date)
        {

            Doctor d = db.Doctor.Where(x => x.id == idDoctor).FirstOrDefault();
            if (d == null)
                throw new noIdExists(idDoctor);
            Location location = db.Location.Where(x => x.locationId == d.codeAdress).FirstOrDefault();
            List<Patient> listPatients = new List<Patient>();
            List<OrderHomeHospitalization> listOrders = db.OrderHomeHospitalization.Where(x => x.idDoctor == idDoctor && x.dateOf.Day == date).ToList();
            List<int> listLocation = new List<int>();
            foreach (OrderHomeHospitalization item in listOrders)
            {
                listPatients.Add(db.Patient.Where(x => x.id == item.idPatient).FirstOrDefault());
            }

            foreach (Patient item in listPatients)
            {
                Location l = db.Location.Where(x => x.locationId == item.locationId).FirstOrDefault();
                listLocation.Add(l.locationId);
            }
            return listLocation;
        }

        //מקבל מגוגל מפס אורך קשת וזמן,ומשקלל את זה למשקל קשת
        public double GetWighetOfEdjeOfTwoPointsFromGoogleMaps(int location1, int location2)
        {
            //{שליחה לגוגל מפס את שתי הנקודות הנ"ל וגוגל מפס מחזירה את משקל הקשת בינם }
            return 12.0;
        }
        //פונקציה שממלאה את האלכסון הראשי במטריצה באפסים שזה מקומות שהמרחק מנקודה לאותה נקודה היא אפס
        public double[,] FillMatrix(int size)
        {
            double[,] rightmatrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                rightmatrix[i, i] = 0.0;
            }
            return rightmatrix;
        }

        //פעולה שבונה את מטריצת המרחקים , מחשבת עבור כל  נקודה את המשקל לכל הנקודות שקיימות
        public double[,] BuildMatrixOfDistance(int idDoctor)
        {
            DailyReportToDoctor d = db.DailyReportToDoctor.Where(x => x.idDoctor == idDoctor).FirstOrDefault();
            List<int> listlocations = BuildListOfLocationsForDoctor(idDoctor, DateTime.Today.Day);
            int sizeofmatrix = listlocations.Count;
            double[,] matrix = new double[sizeofmatrix, sizeofmatrix];
            int i = 0, j = 0;
            matrix = FillMatrix(sizeofmatrix);
            foreach (int item in listlocations)
            {
                foreach (int item2 in listlocations)
                {

                    if (matrix[i, j] != 0.0)
                    {
                        matrix[i, j] = GetWighetOfEdjeOfTwoPointsFromGoogleMaps(item, item2);

                    }
                    j++;

                }
                i++;
            }
            return matrix;

        }

        //פונקציה רקורסיבית המחזירה את משקל המסלול הנמוך ביותר,ובונה עץ עם כל הקודקודים שהיא עברה בהם
        public double GetMinimumCostRoute(int startVertex, HashSet<int> set, Node root)
        {
            if (!set.Any())
            {

                root.ChildNodes = new Node[1] { new Node { Value = _vertices.First(), Selected = true } };

            }

            double totalCost = double.MaxValue;
            int i = 0;
            int selectedIdx = i;
            root.ChildNodes = new Node[set.Count()];

            foreach (var destination in set)
            {
                root.ChildNodes[i] = new Node { Value = destination };

                double costOfVistingCurrentNode = 0;

                var newSet = new HashSet<int>(set);
                newSet.Remove(destination);
                double costOfVisitingOtherNodes = GetMinimumCostRoute(destination, newSet, root.ChildNodes[i]);
                double currentCost = costOfVistingCurrentNode + costOfVisitingOtherNodes;

                if (totalCost > currentCost)
                {
                    totalCost = currentCost;
                    selectedIdx = i;
                }

                i++;
            }

            root.ChildNodes[selectedIdx + 1].Selected = true;

            return totalCost;

        }
        //פונקציה רקורסיבית המקבלת את העץ עם הקודקודים של המסלול ומחזירה את הקודקודים במערך
        public int[] Rec(Node n, int i, int[] arr)
        {



            if (n.ChildNodes != null)
            {
                foreach (var item in n.ChildNodes)
                {
                    if (item.Selected == true)
                    {
                        arr[i++] = item.Value;
                        return Rec(item, i, arr);

                    }


                }

            }

            return arr;

        }
        //פונקצית זימון לבניית העץ,ולהחזירו במערך
        public int[] Zimun(int start)
        {
            Node n = new Node();
            double nn = GetMinimumCostRoute(start, _vertices, n);
            int[] arr5 = new int[_vertices.Count];
            arr5[0] = start;
            arr5 = Rec(n, 1, arr5);
            return arr5;

        }
        //הפונקציה מקבלת מערך של קודים של כתובות ומכינה רשימה של הכתובות הפיזיות(לא קודים)
        public List<FinalResault> End(int id)
        {
            _adjacencyMatrix= BuildMatrixOfDistance(id);
            int[] arr = Zimun( 1);
            List<FinalResault> finalResaults = new List<FinalResault>();
            for (int i = 0; i < arr.Length; i++)
            {
                FinalResault finalResault = new FinalResault();
                Adress adress = db.Adresse.Where(x => x.codeAdress == arr[i]).FirstOrDefault();
                finalResault.x = 0;
                finalResault.y = 0;
                finalResault.street = adress.street;
                finalResault.city = adress.city;
                finalResault.numOfBulding = adress.numberHouse;
                finalResaults.Add(finalResault);
            }
            return finalResaults;
        }





    }
}
