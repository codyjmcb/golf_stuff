using DataModels;
using Repositories;
using System;
using System.Collections.Generic;

namespace ServiceBus
{
    public class Service
    {
        IRepository<Golfer> _golferRepo;

        public Service(IRepository<Golfer> golferRepo)
        {
            _golferRepo = golferRepo;
        }

        public List<Golfer> FindAllGolfers()
        {
            List<Golfer> golferList = (List<Golfer>)_golferRepo.FindAll();

            return golferList;
        }

        public Golfer FindGolfer(string id)
        {
            Golfer golfer = _golferRepo.Find(id);

            return golfer;
        }

        public bool DeleteGolfer(string id)
        {
            if (_golferRepo.Delete(id))
            {
                return true;
            }

            return false;
        }

        public bool AddGolfer(Golfer x)
        {
            if (_golferRepo.Add(x))
            {
                return true;
            }

            return false;
        }

        public bool UpdateGolfer(Golfer x)
        {
            if (_golferRepo.Update(x))
            {
                return true;
            }

            return false;
        }
    }
}
