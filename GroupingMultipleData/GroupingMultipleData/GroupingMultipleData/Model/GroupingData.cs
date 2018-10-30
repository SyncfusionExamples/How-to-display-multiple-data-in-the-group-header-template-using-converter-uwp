using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace GroupingMultipleData
{
    public class GroupingData : INotifyPropertyChanged
    {

        #region Fields

        private ImageSource empimage;
        private ImageSource groupimage;
        private int level;
        private string designation;

        #endregion

        #region Properties

        public ImageSource EmployeeImage
        {
            get { return this.empimage; }
            set
            {
                this.empimage = value;
                this.RaisedOnPropertyChanged("EmployeeImage");
            }
        }
        public ImageSource GroupingImage
        {
            get { return this.groupimage; }
            set
            {
                this.groupimage = value;
                this.RaisedOnPropertyChanged("GroupingImage");
            }
        }
        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    this.RaisedOnPropertyChanged("Level");
                }
            }
        }

        public string Designation
        {
            get { return designation; }
            set
            {
                if (designation != value)
                {
                    designation = value;
                    this.RaisedOnPropertyChanged("Designation");
                }
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
