using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HMSystemMvc.Models;

using HMSystem;
using HMSystem.Models;

namespace HMSystemMvc.Controllers
{
    public class RoomController : Controller
    {
        private HospitalSystem _hosiptal;

        public RoomController(HospitalSystem hospital)
        {
            _hosiptal = hospital;
        }

        public IActionResult Index()
        {
            List<Room> rooms = _hosiptal.GetAllRooms();
            return View(rooms);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(Guid roomId) {
            var room = _hosiptal.GetRoom(roomId);
            return View(room);
        }

        public IActionResult Edit(Guid roomId) {
            var room = _hosiptal.GetRoom(roomId);

            var roomViewModel = new RoomViewModel() {
                RoomLocation = room.RoomLocation,
                RoomStatus = room.RoomStatus,
                RoomIsClean = room.RoomIsClean
            };
            ViewBag.IsEditing = true;
            return View("Form", roomViewModel);
        }

        public IActionResult Form() {
            ViewBag.IsEditing = false;
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomViewModel newRoom) {
            if (ModelState.IsValid) {
                var roomToCreate = new Room(newRoom.RoomLocation, newRoom.RoomStatus, newRoom.RoomIsClean) {
                    RoomLocation = newRoom.RoomLocation,
                    RoomStatus = newRoom.RoomStatus,
                    RoomIsClean = newRoom.RoomIsClean,
                    IsRoomBooked = false
                };
                _hosiptal.AddNewRoom(roomToCreate);

                return RedirectToAction("Index");
            } else {
                return View("Form", newRoom);
            }
        }

        [HttpPost]
        public IActionResult Update(RoomViewModel updatedRoom) {
            if (ModelState.IsValid) {
                var room = new Room(updatedRoom.RoomLocation, updatedRoom.RoomStatus, updatedRoom.RoomIsClean) {
                    RoomLocation = updatedRoom.RoomLocation,
                    RoomStatus = updatedRoom.RoomStatus,
                    RoomIsClean = updatedRoom.RoomIsClean,
                    IsRoomBooked = false
                };
                _hosiptal.UpdateRoom(room);

                return RedirectToAction("Index");
            } else {
                return View("Form", updatedRoom);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
