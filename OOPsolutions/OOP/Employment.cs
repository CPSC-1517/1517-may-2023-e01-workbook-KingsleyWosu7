﻿namespace OOP
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
    }
}