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
        //weight matrix
        double[,] _adjacencyMatrix;
        NewArr[] newArr = new NewArr[1000];
        FinalResault[] finalResault = new FinalResault[1000];
        public OritProjectGoodLuckEntities2 db = OritProjectGoodLuckEntities2.Instance();

        //A doctor match function, which receives a patient and returns the doctor who matches that patient
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


        //Builds a list of locutions for each doctor of all the patients he visits during the shift,
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

        //Gets arc length and time from google, and weights it to arc weight
        public double GetWighetOfEdjeOfTwoPointsFromGoogleMaps(int location1, int location2)
        {
            //{Sending the above two points to Google Maps and Google Maps returns the weight of the arc between them }
            return 12.0;
        }
        //A function that fills the main diagonal in the matrix with zeros, which are places where the distance from a point to that point is zero
        public double[,] FillMatrix(int size)
        {
            double[,] rightmatrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                rightmatrix[i, i] = 0.0;
            }
            return rightmatrix;
        }

        //An operation that builds the distance matrix, calculates for each point the weight for all points that exist
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

        //A recursive function that returns the lowest route weight, and builds a tree with all the vertices it passed through
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
        //A recursive function that receives the tree with the vertices of the route and returns the vertices in the array
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
        //Summoning function to build the tree, and return it in an array
        public int[] Zimun(int start)
        {
            Node n = new Node();
            double nn = GetMinimumCostRoute(start, _vertices, n);
            int[] arr5 = new int[_vertices.Count];
            arr5[0] = start;
            arr5 = Rec(n, 1, arr5);
            return arr5;

        }
        //The function receives an array of address codes and prepares a list of the physical addresses (not codes)
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
