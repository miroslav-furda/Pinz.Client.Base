﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskDO", Namespace="http://schemas.datacontract.org/2004/07/Com.Pinz.Server.DataAccess.Model")]
    [System.SerializableAttribute()]
    public partial class TaskDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActualWorkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateCompletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DueDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCompleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskPriority> PriorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid TaskIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaskNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> UserIdField;
        
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
        public int ActualWork {
            get {
                return this.ActualWorkField;
            }
            set {
                if ((this.ActualWorkField.Equals(value) != true)) {
                    this.ActualWorkField = value;
                    this.RaisePropertyChanged("ActualWork");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateCompleted {
            get {
                return this.DateCompletedField;
            }
            set {
                if ((this.DateCompletedField.Equals(value) != true)) {
                    this.DateCompletedField = value;
                    this.RaisePropertyChanged("DateCompleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DueDate {
            get {
                return this.DueDateField;
            }
            set {
                if ((this.DueDateField.Equals(value) != true)) {
                    this.DueDateField = value;
                    this.RaisePropertyChanged("DueDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsComplete {
            get {
                return this.IsCompleteField;
            }
            set {
                if ((this.IsCompleteField.Equals(value) != true)) {
                    this.IsCompleteField = value;
                    this.RaisePropertyChanged("IsComplete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskPriority> Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((this.PriorityField.Equals(value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartDate {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid TaskId {
            get {
                return this.TaskIdField;
            }
            set {
                if ((this.TaskIdField.Equals(value) != true)) {
                    this.TaskIdField = value;
                    this.RaisePropertyChanged("TaskId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaskName {
            get {
                return this.TaskNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TaskNameField, value) != true)) {
                    this.TaskNameField = value;
                    this.RaisePropertyChanged("TaskName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.Guid> UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskPriority", Namespace="http://schemas.datacontract.org/2004/07/Com.Pinzonline.DomainModel")]
    public enum TaskPriority : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Low = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskStatus", Namespace="http://schemas.datacontract.org/2004/07/Com.Pinzonline.DomainModel")]
    public enum TaskStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskNotStarted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskInProgress = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskComplete = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskWaiting = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskDeferred = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryDO", Namespace="http://schemas.datacontract.org/2004/07/Com.Pinz.Server.DataAccess.Model")]
    [System.SerializableAttribute()]
    public partial class CategoryDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ProjectIdField;
        
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
        public System.Guid CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
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
        public System.Guid ProjectId {
            get {
                return this.ProjectIdField;
            }
            set {
                if ((this.ProjectIdField.Equals(value) != true)) {
                    this.ProjectIdField = value;
                    this.RaisePropertyChanged("ProjectId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProjectDO", Namespace="http://schemas.datacontract.org/2004/07/Com.Pinz.Server.DataAccess.Model")]
    [System.SerializableAttribute()]
    public partial class ProjectDO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CompanyIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ProjectIdField;
        
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
        public System.Guid CompanyId {
            get {
                return this.CompanyIdField;
            }
            set {
                if ((this.CompanyIdField.Equals(value) != true)) {
                    this.CompanyIdField = value;
                    this.RaisePropertyChanged("CompanyId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public System.Guid ProjectId {
            get {
                return this.ProjectIdField;
            }
            set {
                if ((this.ProjectIdField.Equals(value) != true)) {
                    this.ProjectIdField = value;
                    this.RaisePropertyChanged("ProjectId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://pinzonline.com/services", ConfigurationName="TaskServiceReference.ITaskService")]
    public interface ITaskService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllTasksByCategoryId", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllTasksByCategoryIdResponse")]
        System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> ReadAllTasksByCategoryId(System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllTasksByCategoryId", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllTasksByCategoryIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO>> ReadAllTasksByCategoryIdAsync(System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllCategoriesByProjectId", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllCategoriesByProjectIdResponse")]
        System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> ReadAllCategoriesByProjectId(System.Guid projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllCategoriesByProjectId", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllCategoriesByProjectIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO>> ReadAllCategoriesByProjectIdAsync(System.Guid projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllProjectsForUserEmail", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllProjectsForUserEmailResponse")]
        System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ProjectDO> ReadAllProjectsForUserEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/ReadAllProjectsForUserEmail", ReplyAction="http://pinzonline.com/services/ITaskService/ReadAllProjectsForUserEmailResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ProjectDO>> ReadAllProjectsForUserEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/CreateTask", ReplyAction="http://pinzonline.com/services/ITaskService/CreateTaskResponse")]
        Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO CreateTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task, string userEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/CreateTask", ReplyAction="http://pinzonline.com/services/ITaskService/CreateTaskResponse")]
        System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> CreateTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task, string userEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/UpdateTask", ReplyAction="http://pinzonline.com/services/ITaskService/UpdateTaskResponse")]
        Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO UpdateTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/UpdateTask", ReplyAction="http://pinzonline.com/services/ITaskService/UpdateTaskResponse")]
        System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> UpdateTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/DeleteTask", ReplyAction="http://pinzonline.com/services/ITaskService/DeleteTaskResponse")]
        void DeleteTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/DeleteTask", ReplyAction="http://pinzonline.com/services/ITaskService/DeleteTaskResponse")]
        System.Threading.Tasks.Task DeleteTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/CreateCategory", ReplyAction="http://pinzonline.com/services/ITaskService/CreateCategoryResponse")]
        Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO CreateCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/CreateCategory", ReplyAction="http://pinzonline.com/services/ITaskService/CreateCategoryResponse")]
        System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> CreateCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/UpdateCategory", ReplyAction="http://pinzonline.com/services/ITaskService/UpdateCategoryResponse")]
        Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO UpdateCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/UpdateCategory", ReplyAction="http://pinzonline.com/services/ITaskService/UpdateCategoryResponse")]
        System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> UpdateCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/DeleteCategory", ReplyAction="http://pinzonline.com/services/ITaskService/DeleteCategoryResponse")]
        void DeleteCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pinzonline.com/services/ITaskService/DeleteCategory", ReplyAction="http://pinzonline.com/services/ITaskService/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITaskServiceChannel : Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ITaskService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaskServiceClient : System.ServiceModel.ClientBase<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ITaskService>, Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ITaskService {
        
        public TaskServiceClient() {
        }
        
        public TaskServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaskServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> ReadAllTasksByCategoryId(System.Guid categoryId) {
            return base.Channel.ReadAllTasksByCategoryId(categoryId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO>> ReadAllTasksByCategoryIdAsync(System.Guid categoryId) {
            return base.Channel.ReadAllTasksByCategoryIdAsync(categoryId);
        }
        
        public System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> ReadAllCategoriesByProjectId(System.Guid projectId) {
            return base.Channel.ReadAllCategoriesByProjectId(projectId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO>> ReadAllCategoriesByProjectIdAsync(System.Guid projectId) {
            return base.Channel.ReadAllCategoriesByProjectIdAsync(projectId);
        }
        
        public System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ProjectDO> ReadAllProjectsForUserEmail(string email) {
            return base.Channel.ReadAllProjectsForUserEmail(email);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.ProjectDO>> ReadAllProjectsForUserEmailAsync(string email) {
            return base.Channel.ReadAllProjectsForUserEmailAsync(email);
        }
        
        public Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO CreateTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task, string userEmail) {
            return base.Channel.CreateTask(task, userEmail);
        }
        
        public System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> CreateTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task, string userEmail) {
            return base.Channel.CreateTaskAsync(task, userEmail);
        }
        
        public Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO UpdateTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task) {
            return base.Channel.UpdateTask(task);
        }
        
        public System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO> UpdateTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task) {
            return base.Channel.UpdateTaskAsync(task);
        }
        
        public void DeleteTask(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task) {
            base.Channel.DeleteTask(task);
        }
        
        public System.Threading.Tasks.Task DeleteTaskAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.TaskDO task) {
            return base.Channel.DeleteTaskAsync(task);
        }
        
        public Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO CreateCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            return base.Channel.CreateCategory(category);
        }
        
        public System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> CreateCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            return base.Channel.CreateCategoryAsync(category);
        }
        
        public Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO UpdateCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            return base.Channel.UpdateCategory(category);
        }
        
        public System.Threading.Tasks.Task<Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO> UpdateCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            return base.Channel.UpdateCategoryAsync(category);
        }
        
        public void DeleteCategory(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            base.Channel.DeleteCategory(category);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(Com.Pinz.Client.RemoteServiceConsumer.TaskServiceReference.CategoryDO category) {
            return base.Channel.DeleteCategoryAsync(category);
        }
    }
}
