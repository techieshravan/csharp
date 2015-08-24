using System;

namespace Example2
{
    class Book
    {
        private string _title;

        public string Title
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Title cannot be empty or null");

                _title = value;
            }
            get { return _title; }
        }

        public string Author { set; get; }
        public int Pages { set; get; }
    }
}