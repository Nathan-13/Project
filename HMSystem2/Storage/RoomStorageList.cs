using System;
using System.Linq;
using System.Collections.Generic;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public class RoomStorageList : IStoreRoom
    {
        public RoomStorageList() {
            _roomList = new List<Room>();
        }

        // Data members
        private List<Room> _roomList;
        
        public void Create(Room roomToCreate) {
            _roomList.Add(roomToCreate);
        }

        public int NumberOfRooms() {
            return _roomList.Count;
        }

        public void Update(Room roomToUpdate) {
            var room = GetById(roomToUpdate.RoomId);
            room.RoomLocation = roomToUpdate.RoomLocation;
            room.RoomStatus = roomToUpdate.RoomStatus;
            room.RoomIsClean = roomToUpdate.RoomIsClean;
        }

        public void BookRoom(Guid roomId) {
            bool roomExists = false;
            for (int i = 0; i < _roomList.Count; i++) {
                var nextRoom = _roomList[i];
                if (nextRoom.RoomId == roomId) {
                    roomExists = true;
                    nextRoom.Book();
                    break;
                }
            }
            if (!roomExists) {
                throw new Exception($"Room not available in {roomId}");
            }
        }

        public Room GetById(Guid roomId) {
            var room = _roomList.Find(x => x.RoomId == roomId);

            if (room == null) {
                throw new Exception($"Patient {roomId} does not exist!");
            }
            return room;
        }

        public List<Room> GetAll() {
            return _roomList;
        }
        
    }
}