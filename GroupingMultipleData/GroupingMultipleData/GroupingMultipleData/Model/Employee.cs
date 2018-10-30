using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GroupingMultipleData
{
    public class Employee : INotifyPropertyChanged
    {
        #region Fields

        private string employeeName;
        private string contactNumber;
        private string displaystring;
        private GroupingData groupingdata;

        #endregion

        #region Properties

        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                if (employeeName != value)
                {
                    employeeName = value;
                    this.RaisedOnPropertyChanged("EmployeeName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public string DisplayString
        {
            get { return displaystring; }
            set
            {
                displaystring = value;
                this.RaisedOnPropertyChanged("DisplayString");
            }
        }

        public GroupingData GroupingData
        {
            get { return groupingdata; }
            set
            {
                groupingdata = value;
                this.RaisedOnPropertyChanged("GroupingData");

            }
        }

        #endregion

        #region Interface Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
