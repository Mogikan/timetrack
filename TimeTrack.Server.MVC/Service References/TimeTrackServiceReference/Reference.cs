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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Project", Namespace="http://schemas.datacontract.org/2004/07/TimeTrack.Model")]
    [System.SerializableAttribute()]
    public partial class Project : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClosedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FKProjectManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FinishDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TimeTrack.Server.MVC.TimeTrackServiceReference.Employee ProjectManagerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Closed {
            get {
                return this.ClosedField;
            }
            set {
                if ((this.ClosedField.Equals(value) != true)) {
                    this.ClosedField = value;
                    this.RaisePropertyChanged("Closed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FKProjectManager {
            get {
                return this.FKProjectManagerField;
            }
            set {
                if ((this.FKProjectManagerField.Equals(value) != true)) {
                    this.FKProjectManagerField = value;
                    this.RaisePropertyChanged("FKProjectManager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FinishDate {
            get {
                return this.FinishDateField;
            }
            set {
                if ((this.FinishDateField.Equals(value) != true)) {
                    this.FinishDateField = value;
                    this.RaisePropertyChanged("FinishDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Employee ProjectManager {
            get {
                return this.ProjectManagerField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectManagerField, value) != true)) {
                    this.ProjectManagerField = value;
                    this.RaisePropertyChanged("ProjectManager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/TimeTrack.Model")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Timesheet", Namespace="http://schemas.datacontract.org/2004/07/TimeTrack.Model")]
    [System.SerializableAttribute()]
    public partial class Timesheet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TimeTrack.Server.MVC.TimeTrackServiceReference.Employee EmployeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FkEmployeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FkProjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TimeTrack.Server.MVC.TimeTrackServiceReference.Project ProjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SpendTimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Employee Employee {
            get {
                return this.EmployeeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeField, value) != true)) {
                    this.EmployeeField = value;
                    this.RaisePropertyChanged("Employee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FkEmployee {
            get {
                return this.FkEmployeeField;
            }
            set {
                if ((this.FkEmployeeField.Equals(value) != true)) {
                    this.FkEmployeeField = value;
                    this.RaisePropertyChanged("FkEmployee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FkProject {
            get {
                return this.FkProjectField;
            }
            set {
                if ((this.FkProjectField.Equals(value) != true)) {
                    this.FkProjectField = value;
                    this.RaisePropertyChanged("FkProject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Project Project {
            get {
                return this.ProjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectField, value) != true)) {
                    this.ProjectField = value;
                    this.RaisePropertyChanged("Project");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SpendTime {
            get {
                return this.SpendTimeField;
            }
            set {
                if ((this.SpendTimeField.Equals(value) != true)) {
                    this.SpendTimeField = value;
                    this.RaisePropertyChanged("SpendTime");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TimeTrackServiceReference.TimeTrackService")]
    public interface TimeTrackService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjects", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectsResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Project[] GetProjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjects", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectsResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Project[]> GetProjectsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjectById", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectByIdResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Project GetProjectById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetProjectById", ReplyAction="http://tempuri.org/TimeTrackService/GetProjectByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Project> GetProjectByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddProject", ReplyAction="http://tempuri.org/TimeTrackService/AddProjectResponse")]
        void AddProject(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddProject", ReplyAction="http://tempuri.org/TimeTrackService/AddProjectResponse")]
        System.Threading.Tasks.Task AddProjectAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateProject", ReplyAction="http://tempuri.org/TimeTrackService/UpdateProjectResponse")]
        void UpdateProject(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateProject", ReplyAction="http://tempuri.org/TimeTrackService/UpdateProjectResponse")]
        System.Threading.Tasks.Task UpdateProjectAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteProjectById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteProjectByIdResponse")]
        void DeleteProjectById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteProjectById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteProjectByIdResponse")]
        System.Threading.Tasks.Task DeleteProjectByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployees", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeesResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployees", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeeByIdResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Employee GetEmployeeById(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Employee> GetEmployeeByIdAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddEmployee", ReplyAction="http://tempuri.org/TimeTrackService/AddEmployeeResponse")]
        void AddEmployee(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddEmployee", ReplyAction="http://tempuri.org/TimeTrackService/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateEmployee", ReplyAction="http://tempuri.org/TimeTrackService/UpdateEmployeeResponse")]
        void UpdateEmployee(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateEmployee", ReplyAction="http://tempuri.org/TimeTrackService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task UpdateEmployeeAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteEmployeeByIdResponse")]
        void DeleteEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/DeleteEmployeeById", ReplyAction="http://tempuri.org/TimeTrackService/DeleteEmployeeByIdResponse")]
        System.Threading.Tasks.Task DeleteEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheets", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetsResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet[] GetTimeSheets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheets", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetsResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet[]> GetTimeSheetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheetById", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetByIdResponse")]
        TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet GetTimeSheetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/GetTimeSheetById", ReplyAction="http://tempuri.org/TimeTrackService/GetTimeSheetByIdResponse")]
        System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet> GetTimeSheetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddTimesheet", ReplyAction="http://tempuri.org/TimeTrackService/AddTimesheetResponse")]
        void AddTimesheet(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/AddTimesheet", ReplyAction="http://tempuri.org/TimeTrackService/AddTimesheetResponse")]
        System.Threading.Tasks.Task AddTimesheetAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateTimeSheet", ReplyAction="http://tempuri.org/TimeTrackService/UpdateTimeSheetResponse")]
        void UpdateTimeSheet(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimeTrackService/UpdateTimeSheet", ReplyAction="http://tempuri.org/TimeTrackService/UpdateTimeSheetResponse")]
        System.Threading.Tasks.Task UpdateTimeSheetAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet);
        
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
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Project[] GetProjects() {
            return base.Channel.GetProjects();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Project[]> GetProjectsAsync() {
            return base.Channel.GetProjectsAsync();
        }
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Project GetProjectById(int id) {
            return base.Channel.GetProjectById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Project> GetProjectByIdAsync(int id) {
            return base.Channel.GetProjectByIdAsync(id);
        }
        
        public void AddProject(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project) {
            base.Channel.AddProject(project);
        }
        
        public System.Threading.Tasks.Task AddProjectAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project) {
            return base.Channel.AddProjectAsync(project);
        }
        
        public void UpdateProject(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project) {
            base.Channel.UpdateProject(project);
        }
        
        public System.Threading.Tasks.Task UpdateProjectAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Project project) {
            return base.Channel.UpdateProjectAsync(project);
        }
        
        public void DeleteProjectById(int id) {
            base.Channel.DeleteProjectById(id);
        }
        
        public System.Threading.Tasks.Task DeleteProjectByIdAsync(int id) {
            return base.Channel.DeleteProjectByIdAsync(id);
        }
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Employee GetEmployeeById(System.Nullable<int> id) {
            return base.Channel.GetEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Employee> GetEmployeeByIdAsync(System.Nullable<int> id) {
            return base.Channel.GetEmployeeByIdAsync(id);
        }
        
        public void AddEmployee(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public void UpdateEmployee(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee) {
            base.Channel.UpdateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task UpdateEmployeeAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Employee employee) {
            return base.Channel.UpdateEmployeeAsync(employee);
        }
        
        public void DeleteEmployeeById(int id) {
            base.Channel.DeleteEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeByIdAsync(int id) {
            return base.Channel.DeleteEmployeeByIdAsync(id);
        }
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet[] GetTimeSheets() {
            return base.Channel.GetTimeSheets();
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet[]> GetTimeSheetsAsync() {
            return base.Channel.GetTimeSheetsAsync();
        }
        
        public TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet GetTimeSheetById(int id) {
            return base.Channel.GetTimeSheetById(id);
        }
        
        public System.Threading.Tasks.Task<TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet> GetTimeSheetByIdAsync(int id) {
            return base.Channel.GetTimeSheetByIdAsync(id);
        }
        
        public void AddTimesheet(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet) {
            base.Channel.AddTimesheet(timesheet);
        }
        
        public System.Threading.Tasks.Task AddTimesheetAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet) {
            return base.Channel.AddTimesheetAsync(timesheet);
        }
        
        public void UpdateTimeSheet(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet) {
            base.Channel.UpdateTimeSheet(timesheet);
        }
        
        public System.Threading.Tasks.Task UpdateTimeSheetAsync(TimeTrack.Server.MVC.TimeTrackServiceReference.Timesheet timesheet) {
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