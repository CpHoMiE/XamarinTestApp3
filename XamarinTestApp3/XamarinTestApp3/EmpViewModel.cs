using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinTestApp3
{
    class EmpViewModel
    {
        private ObservableCollection<Emp> empList = new ObservableCollection<Emp>();

        public ObservableCollection<Emp> EmpList
        {
            get
            {
                return empList;
            }
            set
            {
                empList = value;
            }
        }

        public EmpViewModel()
        {
            EmpList = new ObservableCollection<Emp>();
        }
    }
}
