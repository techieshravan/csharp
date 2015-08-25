using System;

namespace Example5
{
    class Book
    {
        private string _title;

        public string Title
        {
            set
            {
                if (_title != value)
                {
                    var oldValue = _title;
                    _title = value;
                    if (TitleChanged != null)
                    {
                        var args = new TitleChangedEventArgs
                        {
                            OldValue = oldValue,
                            NewValue = value
                        };
                        TitleChanged(this, args);
                    }
                }
            }
            get { return _title; }
        }

        public string Author { set; get; }
        public int Pages { set; get; }
        public event TitleChangedDelegate TitleChanged;
    }
}