using System;
using System.Collections.Generic;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public interface IStoreRoom
    {
        
        void Create(Room roomToCreate);
        void BookRoom(Guid roomId);
        int NumberOfRooms();  
        Room GetById(Guid roomId);
        void Update(Room roomToUpdate);
        List<Room> GetAll();  
    }
}