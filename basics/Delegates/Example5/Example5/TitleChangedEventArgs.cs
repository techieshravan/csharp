using System;

namespace Example5
{
    public class TitleChangedEventArgs : EventArgs
    {
        public string OldValue { set; get; }
        public string NewValue { set; get; }
    }
}
