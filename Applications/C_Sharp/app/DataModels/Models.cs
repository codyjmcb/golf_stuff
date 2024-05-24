namespace DataModels
{
    public class Golfer
    {
        public string _golferID { get; set; }
        public string _firstName { get; set; }
        public char _middleInitial { get; set; }
        public string _lastName { get; set; }
        public float _handicap { get; set; }

        public Golfer(string golferID, string firstName, char middleInitial, string lastName, float handicap)
        {
            _golferID = golferID;
            _firstName = firstName;
            _middleInitial = middleInitial;
            _lastName = lastName;
            _handicap = handicap;
        }

        public override string ToString()
        {
            return $"{_firstName} {_middleInitial} {_lastName}\r\n";
        }
    }

    public class ClubType
    {
        public byte _uniqueID { get; set; }

        public string _clubName { get; set; }

        public ClubType(byte uniqueID, string clubName)
        {
            _uniqueID = uniqueID;
            _clubName = clubName;
        }

        public override string ToString()
        {
            return _clubName;
        }
    }

    public class GolfCourse
    {
        public string _courseID { get; set; }

        public string _courseName { get; set; }

        public byte _numTees { get; set; }

        public byte _par { get; set; }

        public GolfCourse(string courseID, string courseName, byte numTees, byte par)
        {
            _courseID = courseID;
            _courseName = courseName;
            _numTees = numTees;
            _par = par;
        }

        public override string ToString()
        {
            return _courseName;
        }
    }

    public class TeeInformation
    {
        public short _uniqueID { get; set; }

        public string _courseID { get; set; }

        public string _teeName { get; set; }

        public int _yardage { get; set; }

        public short _slope { get; set; }

        public decimal _rating { get; set; }

        public TeeInformation(short uniqueID, string courseID, string teeName, int yardage, short slope, decimal rating)
        {
            _uniqueID = uniqueID;
            _courseID = courseID;
            _teeName = teeName;
            _yardage = yardage;
            _slope = slope;
            _rating = rating;
        }

        public override string ToString()
        {
            return $"{_courseID}:{_teeName}";
        }
    }

    public class GolfClub
    {
        public short _uniqueID { get; set; }

        public string _golferID { get; set; }

        public byte _clubID { get; set; }

        public decimal _lie { get; set; }

        public string _make { get; set; }

        public string _model { get; set; }

        public GolfClub(short uniqueID, string golferID, byte clubID, decimal lie, string make, string model)
        {
            _uniqueID = uniqueID;
            _golferID = golferID;
            _clubID = clubID;
            _lie = lie;
            _make = make;
            _model = model;
        }

        public override string ToString()
        {
            return $"{_golferID}: {_make} {_model}";
        }
    }

    public class Hole
    {
        public int _uniqueID { get; set; }

        public short _teeID { get; set; }

        public byte _holeNumber { get; set; }

        public short _yardage { get; set; }

        public byte _par { get; set; }

        public byte _handicapRating { get; set; }

        public Hole(int uniqueID, short teeID, byte holeNumber, short yardage, byte par, byte handicapRating)
        {
            _uniqueID = uniqueID;
            _teeID = teeID;
            _holeNumber = holeNumber;
            _yardage = yardage;
            _par = par;
            _handicapRating = handicapRating;
        }

        public override string ToString()
        {
            return $"{_teeID}:{_holeNumber}";
        }
    }
}
