using System;
using System.Collections.Generic;
using HMSystem.Models;
using HMSystem.Storage;

namespace HMSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // var patientStorage = new PatientStorageList();
            // var roomStorage = new RoomStorageList();
            // var doctorStorage = new DoctorStorageList();
            // var billStorage = new BillStorageList();
            // var theHospitalSystem = new HospitalSystem(patientStorage, roomStorage, doctorStorage, billStorage, 7);

            // Console.WriteLine("Welcome to GT Hospital Management System!\n");

            // while(true) {
            //     Console.WriteLine("\nPlease select an option:\n" +
            //         "- a: add new patient\n" + 
            //         "- b: book patient room\n" +
            //         "- s: search for a doctor\n" +
            //         "- m: make hospital bill\n" +
            //         "- d: print all doctors\n" +
            //         "- p: print all patients\n" +
            //         "- r: print all rooms\n" +
            //         "- q: quit\n"
            //     );
            //     string userInput = Console.ReadLine();

            //     // Add new patient to List
            //     // if (userInput == "a") {
            //     //     try {
            //     //         Console.WriteLine("Please enter patient last name: ");
            //     //         string newpatientIdInput = Console.ReadLine();
            //     //         int patientId = int.Parse(newpatientIdInput);

            //     //         theReception.AddNewPatient();

            //     //     } catch (Exception e) {
            //     //         Console.WriteLine($"Error: {e.Message}");
            //     //     }
            //     // }

            //     // Book patient room
            //      if (userInput == "b") {
            //         try {
            //             Console.WriteLine("Please enter room location: ");
            //             string roomLocationInput = Console.ReadLine();
            //             theHospitalSystem.AssignPatientRoom(roomLocationInput);

            //             Console.WriteLine("Room has been booked.");

            //         } catch (Exception e){
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // Search for doctor with last name 
            //     if (userInput == "s") {
            //         try {
            //             Console.WriteLine("Please enter doctor's last name!");
            //             string lastNameToSearch = Console.ReadLine();
            //             List<Doctor> results = theHospitalSystem.SearchForDoctor(lastNameToSearch);
                        
            //             if (results == null) {
            //                 Console.WriteLine("Doctor is unavailible!");
            //             } else {
            //                 Console.WriteLine($"{results}");
            //             }
            //             Console.WriteLine("-------------------------------------------");

            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // Check out a patient 
            //     if (userInput == "c") {
            //         try {
            //             Console.WriteLine("Please enter patient ID to check out: ");
            //             string patientIdInput = Console.ReadLine();
            //             int patientId = int.Parse(patientIdInput);
                        
            //             Bill bill = theHospitalSystem.CheckOutPatient(patientId);
            //             if (bill != null) {
            //                 Console.WriteLine("Patient has been checked out!");
            //             } else {
            //                 Console.WriteLine("Something went wrong. Could not check out book");
            //             }
            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }

            //     }

            //     // Make hospital bills payment
            //     if (userInput == "m") {
            //         try {
            //             Console.WriteLine("Please enter patient ID: ");
            //             string patientIdInput = Console.ReadLine();
            //             int patientId = int.Parse(patientIdInput);

            //             theHospitalSystem.PayHospitalBill(patientId);
            //             Console.WriteLine("Patient {patientId} has paid his hospital bills!");
            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // Print list od rooms
            //     if (userInput == "r") {
            //         try {
            //             List<Room> results = theHospitalSystem.GetAllRooms(); 
            //             foreach (var room in results) {
            //                 Console.WriteLine(room.ToString());
            //             }
            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // Print List of doctors
            //     if (userInput == "d") {
            //         try {
            //             List<Doctor> results = theHospitalSystem.GetAllDoctors(); 
            //             foreach (var doctor in results) {
            //                 Console.WriteLine(doctor.ToString());
            //             }
            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // Print list of patient
            //     if (userInput == "p") {
            //         try {
            //             List<Patient> results = theHospitalSystem.GetAllPatients(); 
            //             foreach (var patient in results) {
            //                 Console.WriteLine(patient.ToString());
            //             }
            //         } catch (Exception e) {
            //             Console.WriteLine($"Error: {e.Message}");
            //         }
            //     }

            //     // quit program
            //     if (userInput == "q") {
            //         break;
            //     }
            // }
            
        }
    }
}
