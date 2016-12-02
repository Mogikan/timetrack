using ASTU.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TimeTrack.Client.UWP.TimeTrackService;

namespace TimeTrack.Client.UWP
{
    public class EmployeesViewModel : Observable
    {
        public EmployeesViewModel()
        {
            var binding = new BasicHttpBinding();
            _serviceClient = new TimeTrackService.TimeTrackServiceClient(binding, new EndpointAddress(new Uri("http://localhost:9999/TimetrackService")));
            LoadData();
        }
        private TimeTrackService.TimeTrackServiceClient _serviceClient;
        public async void LoadData()
        {
            Employees = await _serviceClient.GetEmployeesAsync();
        }
        ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
                NotifyPropertyChanged(() => Employees);
            }
        }
    }
}
