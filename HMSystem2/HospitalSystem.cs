using System;
using System.Collections.Generic;
using HMSystem.Models;
using HMSystem.Storage;

namespace HMSystem
{
    public class HospitalSystem
    {
        // Constructor
        public HospitalSystem(IStorePatient patientStorageArg, IStoreRoom roomStorageArg, IStoreDoctor doctorStorageArg, 
                            IStoreBill billStorageArg) {
            _patientStorage = patientStorageArg;
            _roomStorage = roomStorageArg;
            _doctorStorage = doctorStorageArg;
            _billStorage = billStorageArg;
            _capacity = 20;
           
            // Test doctors
            // Doctor theDoctor1 = new Doctor("Spearman","David","Family Physician", 13069742367,"20 Rush Street, Regina, SK S5W 2G8", 
            //                                 "david.spearman@hlmclinic.org", 2, "https://i.ibb.co/CK3SgsK/spearman.jpg");
            // Doctor theDoctor2 = new Doctor("Wright","Sarah","Professor, Oncologist", 13063789265, "38 High Road, Regina, SK S7W 2A1", 
            //                                 "sarah.wright@hlmclinic.org", 0, "https://i.ibb.co/sWjpnGc/wright.jpg");
            // Doctor theDoctor3 = new Doctor("Pearson","Derek","Emergency Medicine Specialist", 13066425612, "671 Green Drive, Regina, SK S4J 8J1", 
            //                                 "derek.pearson@hlmclinic.org", 1, "https://i.ibb.co/CBCqk4X/paul.jpg");
            // Doctor theDoctor4 = new Doctor("Binder","Wallace","Professor, Neurologist", 13063972753,"34 Perth Way, Regina, SK S3Y 6H3", 
            //                                 "wallace.binder@hlmclinic.org", 0, "https://i.ibb.co/4g4NyB9/binder.jpg");
            // Doctor theDoctor5 = new Doctor("Martin","Janet","Obstetricians and Gynecologists", 13063852973, "76 Grange Road, Regina, SK S3W 0A2", 
            //                                 "janet.martin@hlmclinic.org", 2, "https://i.ibb.co/y0Sgpbw/martin.jpg");
            // Doctor theDoctor6 = new Doctor("Painter","Paul","Cardiologist", 13063854432,"1853 Le Gard, Regina, SK S4N 3A1", 
            //                                 "paul.painter@hlmclinic.org", 0, "https://i.ibb.co/cxhV0p2/painter.jpg");

            // // Test patients
            // Patient thepatient1 = new Patient("Mr","Paul","Simmons", new DateTime(1990, 2, 28), 13063876258,"38 Wainright Street, Regina SK S3W 0A7", "Heart Disease", new DateTime(2020, 12, 07),'M');
            // Patient thepatient2 = new Patient("Miss","Wendy","Cartright", new DateTime(1995, 6, 18), 13064578221,"113 Lonsdale Street, Regina SK S4J 8G2", "Pregnacy", new DateTime(2020, 12, 02), 'F');
            // Patient thepatient3 = new Patient("Mr","Jimmy","Dreab", new DateTime(1985, 10, 23), 13063852314,"56 Fontwell Street, Regina SK S2G 1A4", "Cancer", new DateTime(2020, 12, 04), 'M');
            // Patient thepatient4 = new Patient("Miss","Jane","Bently", new DateTime(2000, 7, 14), 13067865268,"34 High Street, Regina SK S4S 7X2", "Allegies", new DateTime(2020, 12, 07), 'F');
            // Patient thepatient5 = new Patient("Mr","Yiu-Sing","Pang", new DateTime(1991, 11, 29), 13069745568,"971 High Road, Regina SK S2W 0B7", "Cold and Flu", new DateTime(2020, 12, 07), 'M');
        
            // // Test rooms. Note, E - room empty, O - room occupied with patient, Y - yes room is clean, and N - room is not clean.
            // Room room1 = new Room("Mother and Baby Unit", 'E', 'Y');
            // Room room2 = new Room("Mother and Baby Unit", 'E', 'N');
            // Room room3 = new Room("Emergency Unit", 'O', 'Y');
            // Room room4 = new Room("Emergency Unit", 'O', 'Y');
            // Room room5 = new Room("Emergency Unit", 'O', 'N');
            // Room room6 = new Room("Intensive Care Unit", 'O', 'Y');
            // Room room7 = new Room("Intensive Care Unit", 'O', 'Y');


            
            // _doctorStorage.Create(theDoctor1); _doctorStorage.Create(theDoctor2);
            // _doctorStorage.Create(theDoctor3); _doctorStorage.Create(theDoctor4);
            // _doctorStorage.Create(theDoctor5); _doctorStorage.Create(theDoctor6);

            // _patientStorage.Create(thepatient1); _patientStorage.Create(thepatient2);
            // _patientStorage.Create(thepatient3); _patientStorage.Create(thepatient4);
            // _patientStorage.Create(thepatient5);

            // _roomStorage.Create(room1); _roomStorage.Create(room2);
            // _roomStorage.Create(room3); _roomStorage.Create(room4);
            // _roomStorage.Create(room5); _roomStorage.Create(room6);
            // _roomStorage.Create(room7);
        }
        
        // Data members
        private IStorePatient _patientStorage;
        private IStoreRoom _roomStorage;
        private IStoreDoctor _doctorStorage;
        private IStoreBill _billStorage;
        int _capacity;
        
       
        // Methods
        public Bill DischargePatient(Guid patientIdToCheckout) {
            var patient = _patientStorage.GetByPatientId(patientIdToCheckout);
            patient.CheckOut();

            var bill = new Bill(patient);
            _billStorage.Create(bill);
            return bill;
        }

        public void PayHospitalBill(Guid patientId) {
            Bill bill = _billStorage.GetByPatientId(patientId);
            bill.BillsPaid();
        }

        public void AddNewPatient(Patient newPatient){
            if (_patientStorage.NumberOfPatients() < _capacity) {
                _patientStorage.Create(newPatient);
                Console.WriteLine("Received a new patient!");
            } else {
                throw new Exception("Sorry, hospital rooms are full!");
            }
        }

        // public void AssignPatientToDoctor()

        public Patient GetPatient(Guid patientId) {
            return _patientStorage.GetByPatientId(patientId);
        }

        public void UpdatePatient(Patient patientToUpdate) {
            _patientStorage.Update(patientToUpdate);
        }

        public List<Patient> GetAllPatients() {
            return _patientStorage.GetAll();
        }

        // public List<Doctor> SearchForDoctor(string lastNameToSearch) {
        //     return _doctorStorage.GetByLastName(lastNameToSearch);
        // }

        public Doctor AddNewDoctor(Doctor newDoctor) {
            _doctorStorage.Create(newDoctor);
            return newDoctor;
        }
        public Doctor GetDoctor(Guid doctorId) {
            return _doctorStorage.GetById(doctorId);
        }

        public void UpdateDoctor(Doctor doctorToUpdate) {
            _doctorStorage.Update(doctorToUpdate);
        }

        public List<Doctor> GetAllDoctors() {
            return _doctorStorage.GetAll();
        }

        public Room AddNewRoom(Room newRoom) {
            _roomStorage.Create(newRoom);
            return newRoom;
        }

        public void AssignPatientRoom(Guid roomId) {
            _roomStorage.BookRoom(roomId);
        }

        public List<Room> GetAllRooms() {
            return _roomStorage.GetAll();
        }

        public Room GetRoom(Guid roomId) {
            return _roomStorage.GetById(roomId);
        }

        public void UpdateRoom(Room roomToUpdate) {
            _roomStorage.Update(roomToUpdate);
        }
        
        // public 

        // public void GenerateBill() {

        // }

        // public void MaintainPatient() {

        // }

        // public void Details() {

        // }

        // public void DrawSalary() {

        // }


    }

    
}