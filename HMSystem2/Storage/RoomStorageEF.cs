using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public class RoomStorageEF : IStoreRoom
    {
        private HospitalContext _context;

        public RoomStorageEF(HospitalContext context) {
            _context = context;
        }

        public void Create(Room roomToCreate) {
            var roomDb = ConvertToDb(roomToCreate);
            _context.Rooms.Add(roomDb);
            _context.SaveChanges();
        }

        public int NumberOfRooms() {
            var roomsFromDb = _context.Rooms.Count();
            return roomsFromDb;
        }

        public void Update(Room roomToUpdate) {
            var roomDb = ConvertToDb(roomToUpdate);
            _context.Rooms.Update(roomDb);
            _context.SaveChanges();
        }

        public void BookRoom(Guid roomId) {
            var roomFromDb = _context.Rooms
                .AsNoTracking()
                .Where(x => x.IsRoomBooked == false)
                .First(x => x.RoomId == roomId);
            roomFromDb.IsRoomBooked = true;
            _context.Rooms.Update(roomFromDb);
            _context.SaveChanges();
        }

        public Room GetById(Guid roomId) {
            var roomDb = _context.Rooms
                .AsNoTracking()
                .First(x => x.RoomId == roomId);
            var room = ConverFromDb(roomDb);
            return room;
        }

        public List<Room> GetAll() {
            List<Room> results = new List<Room>();

            var roomsFromDb = _context.Rooms.ToList();
            foreach(var roomFromDb in roomsFromDb) {
                var nextRoom = ConverFromDb(roomFromDb);
                results.Add(nextRoom);
            }
            return results;
        }

        private static EFModels.Room ConvertToDb (Room room) {
            return new EFModels.Room() {
                RoomId = room.RoomId,
                RoomLocation = room.RoomLocation,
                RoomStatus = room.RoomStatus,
                IsRoomBooked = room.IsRoomBooked,
                RoomIsClean = room.RoomIsClean,
            };
        }

        private static Room ConverFromDb(EFModels.Room roomDb) {
            return new Room(roomDb.RoomLocation, roomDb.RoomStatus, roomDb.RoomIsClean) {
                RoomId = roomDb.RoomId,
                RoomLocation = roomDb.RoomLocation,
                RoomStatus = roomDb.RoomStatus,
                IsRoomBooked = roomDb.IsRoomBooked,
                RoomIsClean = roomDb.RoomIsClean,
            };
        }
        
    }
}