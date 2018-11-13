using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm.Model
{
    public class RadioGroupDemoViewModel : INotifyPropertyChanged
    {
        public RadioGroupDemoViewModel()
        {
            myList = new Dictionary<int, string>();
            selectedIndex = -1;
            //LoadData();
        }


        public Dictionary<int, string> LoadData()
        {

            for (int i = 0; i < 3; i++)
            {
                MyList.Add(i, "Item " + i);
            }
            return MyList;

        }


        private Dictionary<int, string> myList;
        public Dictionary<int, string> MyList
        {
            get { return myList; }
            set
            {
                myList = value;
                NotifyPropertyChanged("MyList");
            }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                if (value == selectedIndex) return;
                selectedIndex = value;
                NotifyPropertyChanged("SelectedIndex");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static implicit operator Dictionary<object, object>(RadioGroupDemoViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
