using DataModels;
using Repositories;
using System;
using System.Collections.Generic;

namespace ServiceBus
{
    public class Service
    {
        IRepository<Golfer> _golferRepo;
        IRepository<ClubType> _clubTypeRepo;
        IRepository<GolfCourse> _courseRepo;
        IItemsForRepository<TeeInformation, GolfCourse> _teeInformationRepo;

        public Service(
            IRepository<Golfer> golferRepo,
            IRepository<ClubType> clubTypeRepo,
            IRepository<GolfCourse> courseRepo,
            IItemsForRepository<TeeInformation, GolfCourse> teeInformationRepo
            )
        {
            _golferRepo = golferRepo;
            _clubTypeRepo = clubTypeRepo;
            _courseRepo = courseRepo;
            _teeInformationRepo = teeInformationRepo;
        }

        public List<Golfer> FindAllGolfers()
        {
            return (List<Golfer>)_golferRepo.FindAll();
        }

        public Golfer FindGolfer(string id)
        {
            return _golferRepo.Find(id);
        }

        public bool DeleteGolfer(string id)
        {
            return _golferRepo.Delete(id);
        }

        public bool AddGolfer(Golfer x)
        {
            return _golferRepo.Add(x);
        }

        public bool UpdateGolfer(Golfer x)
        {
            return _golferRepo.Update(x);
        }

        public List<ClubType> FindAllClubTypes()
        {
            return (List<ClubType>)_clubTypeRepo.FindAll();
        }

        public bool UpdateClubType(ClubType x)
        {
            return _clubTypeRepo.Update(x);
        }

        public bool AddClubType(ClubType x)
        {
            return _clubTypeRepo.Add(x);
        }

        public ClubType FindClubType(string id)
        {
            return _clubTypeRepo.Find(id);
        }

        public bool DeleteClubType(string id)
        {
            return _clubTypeRepo.Delete(id);
        }

        public List<GolfCourse> FindAllCourses()
        {
            return (List<GolfCourse>)_courseRepo.FindAll();
        }

        public GolfCourse FindCourse(string id)
        {
            return _courseRepo.Find(id);
        }

        public bool UpdateCourse(GolfCourse x)
        {
            return _courseRepo.Update(x);
        }

        public bool AddCourse(GolfCourse x)
        {
            return _courseRepo.Add(x);
        }

        public bool DeleteCourse(string id)
        {
            return _courseRepo.Delete(id);
        }

        public List<TeeInformation> FindAllTeeInfo()
        {
            return (List<TeeInformation>)_teeInformationRepo.FindAll();
        }

        public TeeInformation FindTeeInformation(string id)
        {
            return _teeInformationRepo.Find(id);
        }

        public bool UpdateTeeInformation(TeeInformation x)
        {
            return _teeInformationRepo.Update(x);
        }

        public bool AddTeeInformation(TeeInformation x)
        {
            return _teeInformationRepo.Add(x);
        }

        public bool DeleteTeeInformation(string id)
        {
            return _teeInformationRepo.Delete(id);
        }
    }
}
