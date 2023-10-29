using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEntities
{
    public class ClassUser
    {
        public int RolId { get; set; }
        public int WorkId { get; set; }
        public int TaskId { get; set; }
        public int UserGroupId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ProjectName { get; set; }
        public int StatusId { get; set; }
        public string ConfirmPassword { get; set; }
        int _UserId;
        string _UserName;
        string _Password;
        string _Name;
        string _MobileNo;
        string _EmailId;
        int _createdBy;
        int _UpdatedBy;
        int _EmployeeId;
        DateTime _ExpiryDate;
        int _UserGroup;
        int _BranchId;

        public int BranchId
        {
            get { return _BranchId; }
            set { _BranchId = value; }
        }
        public int UserGroup
        {
            get { return _UserGroup; }
            set { _UserGroup = value; }
        }

        public DateTime ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public int UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }

        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }

        public string MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }
}
