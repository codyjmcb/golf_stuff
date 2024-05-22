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

}
