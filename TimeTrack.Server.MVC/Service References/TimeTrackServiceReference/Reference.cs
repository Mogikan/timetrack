﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTrack.Server.MVC.TimeTrackServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TimeTrackServiceReference.TimeTrackService")]
    public interface TimeTrackService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjects", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectsResponse")]
        TimeTrack.Model.Project[] GetProjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjects", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectsResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Project[]> GetProjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjectById", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectByIdResponse")]
        TimeTrack.Model.Project GetProjectById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjectById", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Project> GetProjectByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddProject", ReplyAction="http://tempuri.org/TimeTrackService/AddProjectResponse")]
        void AddProject(TimeTrack.Model.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddProject", ReplyAction="http://tempuri.org/TimeTrackService/AddProjectResponse")]
        System.Threading.Tasks.Task AddProjectAsync(TimeTrack.Model.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateProject", ReplyAction="http://tempuri.org/TimeTrackService/UpdateProjectResponse")]
        void UpdateProject(TimeTrack.Model.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateProject", ReplyAction="http://tempuri.org/TimeTrackService/UpdateProjectResponse")]
        System.Threading.Tasks.Task UpdateProjectAsync(TimeTrack.Model.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteProjectById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteProjectByIdResponse")]
        void DeleteProjectById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteProjectById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteProjectByIdResponse")]
        System.Threading.Tasks.Task DeleteProjectByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployees", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeesResponse")]
        TimeTrack.Model.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployees", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeeByIdResponse")]
        TimeTrack.Model.Employee GetEmployeeById(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Employee> GetEmployeeByIdAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddEmployee", ReplyAction="http://tempuri.org/TimeTrackService/AddEmployeeResponse")]
        void AddEmployee(TimeTrack.Model.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddEmployee", ReplyAction="http://tempuri.org/TimeTrackService/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(TimeTrack.Model.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateEmployee", ReplyAction="http://tempuri.org/TimeTrackService/UpdateEmployeeResponse")]
        void UpdateEmployee(TimeTrack.Model.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateEmployee", ReplyAction="http://tempuri.org/TimeTrackService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task UpdateEmployeeAsync(TimeTrack.Model.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteEmployeeByIdResponse")]
        void DeleteEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteEmployeeByIdResponse")]
        System.Threading.Tasks.Task DeleteEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheets", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetsResponse")]
        TimeTrack.Model.Timesheet[] GetTimeSheets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheets", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetsResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Timesheet[]> GetTimeSheetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheetById", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetByIdResponse")]
        TimeTrack.Model.Timesheet GetTimeSheetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheetById", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Model.Timesheet> GetTimeSheetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddTimesheet", ReplyAction="http://tempuri.org/TimeTrackService/AddTimesheetResponse")]
        void AddTimesheet(TimeTrack.Model.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddTimesheet", ReplyAction="http://tempuri.org/TimeTrackService/AddTimesheetResponse")]
        System.Threading.Tasks.Task AddTimesheetAsync(TimeTrack.Model.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateTimeSheet", ReplyAction="http://tempuri.org/TimeTrackService/UpdateTimeSheetResponse")]
        void UpdateTimeSheet(TimeTrack.Model.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateTimeSheet", ReplyAction="http://tempuri.org/TimeTrackService/UpdateTimeSheetResponse")]
        System.Threading.Tasks.Task UpdateTimeSheetAsync(TimeTrack.Model.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteTimesheetById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteTimesheetByIdResponse")]
        void DeleteTimesheetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteTimesheetById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteTimesheetByIdResponse")]
        System.Threading.Tasks.Task DeleteTimesheetByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TimeTrackServiceChannel : TimeTrack.Server.MVC.TimeTrackServiceReference.TimeTrackService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimeTrackServiceClient : System.ServiceModel.ClientBase<TimeTrack.Server.MVC.TimeTrackServiceReference.TimeTrackService>, TimeTrack.Server.MVC.TimeTrackServiceReference.TimeTrackService {
        
        public TimeTrackServiceClient() {
        }
        
        public TimeTrackServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimeTrackServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimeTrackServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimeTrackServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TimeTrack.Model.Project[] GetProjects() {
            return base.Channel.GetProjects();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Project[]> GetProjectsAsync() {
            return base.Channel.GetProjectsAsync();
        }
        
        public TimeTrack.Model.Project GetProjectById(int id) {
            return base.Channel.GetProjectById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Project> GetProjectByIdAsync(int id) {
            return base.Channel.GetProjectByIdAsync(id);
        }
        
        public void AddProject(TimeTrack.Model.Project project) {
            base.Channel.AddProject(project);
        }
        
        public System.Threading.Tasks.Task AddProjectAsync(TimeTrack.Model.Project project) {
            return base.Channel.AddProjectAsync(project);
        }
        
        public void UpdateProject(TimeTrack.Model.Project project) {
            base.Channel.UpdateProject(project);
        }
        
        public System.Threading.Tasks.Task UpdateProjectAsync(TimeTrack.Model.Project project) {
            return base.Channel.UpdateProjectAsync(project);
        }
        
        public void DeleteProjectById(int id) {
            base.Channel.DeleteProjectById(id);
        }
        
        public System.Threading.Tasks.Task DeleteProjectByIdAsync(int id) {
            return base.Channel.DeleteProjectByIdAsync(id);
        }
        
        public TimeTrack.Model.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public TimeTrack.Model.Employee GetEmployeeById(System.Nullable<int> id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Employee> GetEmployeeByIdAsync(System.Nullable<int> id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public void AddEmployee(TimeTrack.Model.Employee employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(TimeTrack.Model.Employee employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public void UpdateEmployee(TimeTrack.Model.Employee employee) {
            base.Channel.UpdateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task UpdateEmployeeAsync(TimeTrack.Model.Employee employee) {
            return base.Channel.UpdateEmployeeAsync(employee);
        }
        
        public void DeleteEmployeeById(int id) {
            base.Channel.DeleteEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeByIdAsync(int id) {
            return base.Channel.DeleteEmployeeByIdAsync(id);
        }
        
        public TimeTrack.Model.Timesheet[] GetTimeSheets() {
            return base.Channel.GetTimeSheets();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Timesheet[]> GetTimeSheetsAsync() {
            return base.Channel.GetTimeSheetsAsync();
        }
        
        public TimeTrack.Model.Timesheet GetTimeSheetById(int id) {
            return base.Channel.GetTimeSheetById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Model.Timesheet> GetTimeSheetByIdAsync(int id) {
            return base.Channel.GetTimeSheetByIdAsync(id);
        }
        
        public void AddTimesheet(TimeTrack.Model.Timesheet timesheet) {
            base.Channel.AddTimesheet(timesheet);
        }
        
        public System.Threading.Tasks.Task AddTimesheetAsync(TimeTrack.Model.Timesheet timesheet) {
            return base.Channel.AddTimesheetAsync(timesheet);
        }
        
        public void UpdateTimeSheet(TimeTrack.Model.Timesheet timesheet) {
            base.Channel.UpdateTimeSheet(timesheet);
        }
        
        public System.Threading.Tasks.Task UpdateTimeSheetAsync(TimeTrack.Model.Timesheet timesheet) {
            return base.Channel.UpdateTimeSheetAsync(timesheet);
        }
        
        public void DeleteTimesheetById(int id) {
            base.Channel.DeleteTimesheetById(id);
        }
        
        public System.Threading.Tasks.Task DeleteTimesheetByIdAsync(int id) {
            return base.Channel.DeleteTimesheetByIdAsync(id);
        }
    }
}
