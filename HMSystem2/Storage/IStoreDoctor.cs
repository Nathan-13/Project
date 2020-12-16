using System;
using System.Collections.Generic;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public interface IStoreDoctor
    {
          
        void Create(Doctor doctorToCreate);

        Doctor GetById(Guid doctorId);

        void Update(Doctor doctorToUpdate);
           
        List<Doctor> GetAll();

    }
}