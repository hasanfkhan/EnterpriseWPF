using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace EnterpriseWPF
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _title;
        private DateTime _startDate;
        private bool _wasReelected;
        private Party _affiliation;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public bool WasReelected
        {
            get { return _wasReelected; }
            set
            {
                _wasReelected = value;
                OnPropertyChanged();
            }
        }

        public Party Affiliation
        {
            get { return _affiliation; }
            set
            {
                _affiliation = value;
                OnPropertyChanged();
            }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        public Employee()
        {
            
        }

        public Employee(string name, string title, DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee
            {
                Name = "Tom",
                Title = "Developer"
            };
            return emp;
        }

        //public static ObservableCollection<Employee> GetEmployees()
        //{
        //    var employees = new ObservableCollection<Employee>
        //    {
        //        new Employee{ Name = "Thomas Warring", Title = "Junior Software Developer"},
        //        new Employee{ Name = "Greg Cherry", Title = "Junior Software Developer"},
        //        new Employee{ Name = "James Joseph", Title = "Software Developer"},
        //        new Employee{ Name = "Hasan Fahim", Title = "Software Developer"},
        //        new Employee{ Name = "Kashif Usman", Title = "Software Developer"}
        //    };
        //    return employees;
        //}

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>
            {
                new Employee{ Name = "Washington", Title = "President 1", WasReelected = true, Affiliation = Party.Independent},
                new Employee{ Name = "Adams", Title = "President 2", WasReelected = false, Affiliation = Party.Federalist},
                new Employee{ Name = "Jefferson", Title = "President 3", WasReelected = true, Affiliation = Party.DemocratRepublican},
                new Employee{ Name = "Madison", Title = "President 4", WasReelected = true, Affiliation = Party.DemocratRepublican},
                new Employee{ Name = "Monroe", Title = "President 5", WasReelected = true, Affiliation = Party.DemocratRepublican}
            };
            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }

    public enum Party
    {
        Independent,
        Federalist,
        DemocratRepublican
    }
}
