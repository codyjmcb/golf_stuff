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

        public Service(IRepository<Golfer> golferRepo, IRepository<ClubType> clubTypeRepo, IRepository<GolfCourse> courseRepo)
        {
            _golferRepo = golferRepo;
            _clubTypeRepo = clubTypeRepo;
            _courseRepo = courseRepo;
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

        public List<ClubType> FindAllClubTypes()
        {
            List<ClubType> clubTypesList = (List<ClubType>)_clubTypeRepo.FindAll();

            return clubTypesList;
        }

        public bool UpdateClubType(ClubType x)
        {
            if (_clubTypeRepo.Update(x))
            {
                return true;
            }
            return false;
        }

        public bool AddClubType(ClubType x)
        {
            if (_clubTypeRepo.Add(x))
            {
                return true;
            }
            return false;
        }

        public ClubType FindClubType(string id)
        {
            return _clubTypeRepo.Find(id);
        }

        public bool DeleteClubType(string id)
        {
            if (_clubTypeRepo.Delete(id))
            {
                return true;
            }
            return false;
        }

        public List<GolfCourse> FindAllCourses()
        {
            List<GolfCourse> courses = (List<GolfCourse>)_courseRepo.FindAll();

            return courses;
        }

        public GolfCourse FindCourse(string id)
        {
            GolfCourse course = _courseRepo.Find(id);

            return course;
        }

        public bool UpdateCourse(GolfCourse x)
        {
            if (_courseRepo.Update(x))
            {
                return true;
            }
            return false;
        }

        public bool AddCourse(GolfCourse x)
        {
            if (_courseRepo.Add(x))
            {
                return true;
            }
            return false;
        }

        public bool DeleteCourse(string id)
        {
            if (_courseRepo.Delete(id))
            {
                return true;
            }
            return false;
        }
    }
}
