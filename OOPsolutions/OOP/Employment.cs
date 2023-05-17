namespace OOP
{
    public class Employment
    {
        //fields
        private SupervisoryLevel _level;
        private string _Title;
        private double _Years;

        //properties
        //are associated wth a single bunch of data
        //does not have any value

        public string Title
        {
            get { return _Title; }

            set
            {
             if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is required");
                }
                _Title = value;
            }

        }

        public SupervisoryLevel Level
        {
            get { return _level; }


            private set
            {
                //test for enum
                if (!Enum.IsDefined(typeof(SupervisoryLevel), value))
                {
                    throw new ArgumentException($"Supervisory level is invalid: {value}");
                }


            }
        }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value");
                }
                _Years = value;
            }

            
        }

        public DateTime StartDate { get; set; }


    }
}