#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class EmployeeShiftManagement
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeId { get; set; }
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public bool? IsReadonly { get; set; }

        public List<EmployeeShiftManagement> GetEmployeeShiftManagementData()
        {
            List<EmployeeShiftManagement> employeeData = new List<EmployeeShiftManagement>();
            employeeData.Add(new EmployeeShiftManagement { Id = 1, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 2, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 3, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 4, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 5, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 6, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 7, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 8, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 9, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 10, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 11, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 12, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 13, RoleId = 1, DesignationId = 1, EmployeeId = 1, Subject = "John", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 14, RoleId = 1, DesignationId = 1, EmployeeId = 2, Subject = "Nashil", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 15, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 16, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 17, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 18, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 19, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 20, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 21, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 22, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 23, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 24, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 25, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 26, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 27, RoleId = 1, DesignationId = 2, EmployeeId = 3, Subject = "Jennifer", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 28, RoleId = 1, DesignationId = 2, EmployeeId = 4, Subject = "William", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 29, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 30, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 31, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 32, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 33, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 34, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 35, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Leave (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 36, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 37, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 38, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 39, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 40, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 41, RoleId = 1, DesignationId = 3, EmployeeId = 5, Subject = "David", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 42, RoleId = 1, DesignationId = 3, EmployeeId = 6, Subject = "Michael", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 43, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 44, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 45, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 46, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 47, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 48, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 49, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 50, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 51, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 52, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Leave (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 53, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 54, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 55, RoleId = 1, DesignationId = 4, EmployeeId = 7, Subject = "Thomas", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 56, RoleId = 1, DesignationId = 4, EmployeeId = 8, Subject = "Daniel", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 57, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 58, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 59, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 60, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 61, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 62, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 63, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 64, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 65, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 66, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 67, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 68, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 69, RoleId = 2, DesignationId = 5, EmployeeId = 9, Subject = "Emma", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Leave (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 70, RoleId = 2, DesignationId = 5, EmployeeId = 10, Subject = "Lily", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 71, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 72, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 73, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 74, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 75, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 76, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 77, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 78, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 79, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 80, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 81, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 82, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 83, RoleId = 2, DesignationId = 6, EmployeeId = 11, Subject = "Ava", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 84, RoleId = 2, DesignationId = 6, EmployeeId = 12, Subject = "Grace", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 85, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 86, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 87, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 88, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 89, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 90, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 91, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 92, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 93, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 94, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 95, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 96, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Leave (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 97, RoleId = 3, DesignationId = 7, EmployeeId = 13, Subject = "James", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 98, RoleId = 3, DesignationId = 7, EmployeeId = 14, Subject = "Benjamin", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 99, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-02T01:30:00.000Z", EndTime = "2025-03-02T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 100, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-02T09:30:00.000Z", EndTime = "2025-03-02T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 101, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-03T01:30:00.000Z", EndTime = "2025-03-03T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 102, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-03T09:30:00.000Z", EndTime = "2025-03-03T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 103, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-04T01:30:00.000Z", EndTime = "2025-03-04T09:30:00.000Z", Description = "Available (Morning Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 104, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-04T09:30:00.000Z", EndTime = "2025-03-04T17:30:00.000Z", Description = "Available (Evening Shift)", IsReadonly = true });
            employeeData.Add(new EmployeeShiftManagement { Id = 105, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-05T01:30:00.000Z", EndTime = "2025-03-05T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 106, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-05T09:30:00.000Z", EndTime = "2025-03-05T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 107, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-06T01:30:00.000Z", EndTime = "2025-03-06T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 108, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-06T09:30:00.000Z", EndTime = "2025-03-06T17:30:00.000Z", Description = "Available (Evening Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 109, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-07T01:30:00.000Z", EndTime = "2025-03-07T09:30:00.000Z", Description = "Available (Morning Shift)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 110, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-07T09:30:00.000Z", EndTime = "2025-03-07T17:30:00.000Z", Description = "Available (Evening Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 111, RoleId = 3, DesignationId = 8, EmployeeId = 15, Subject = "Olivia", StartTime = "2025-03-08T01:30:00.000Z", EndTime = "2025-03-08T09:30:00.000Z", Description = "Available (Morning Shift - Swap-Request)" });
            employeeData.Add(new EmployeeShiftManagement { Id = 112, RoleId = 3, DesignationId = 8, EmployeeId = 16, Subject = "Chloe", StartTime = "2025-03-08T09:30:00.000Z", EndTime = "2025-03-08T17:30:00.000Z", Description = "Available (Evening Shift)" });

            return employeeData;
        }
    }
    public class EmployeeImage
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public List<EmployeeImage> GetEmployeeImage()
        {
            List<EmployeeImage> employeeImages = new List<EmployeeImage>();

            employeeImages.Add(new EmployeeImage { Name = "John", Image = "../Content/images/EmployeeShiftImage/robert.png" });
            employeeImages.Add(new EmployeeImage { Name = "Nashil", Image = "../Content/images/EmployeeShiftImage/nancy.png" });
            employeeImages.Add(new EmployeeImage { Name = "Jennifer", Image = "../Content/images/EmployeeShiftImage/jennifer.png" });
            employeeImages.Add(new EmployeeImage { Name = "William", Image = "../Content/images/EmployeeShiftImage/william.png" });
            employeeImages.Add(new EmployeeImage { Name = "David", Image = "../Content/images/EmployeeShiftImage/david.png" });
            employeeImages.Add(new EmployeeImage { Name = "Michael", Image = "../Content/images/EmployeeShiftImage/michael.png" });
            employeeImages.Add(new EmployeeImage { Name = "Thomas", Image = "../Content/images/EmployeeShiftImage/thomas.png" });
            employeeImages.Add(new EmployeeImage { Name = "Daniel", Image = "../Content/images/EmployeeShiftImage/robson.png" });
            employeeImages.Add(new EmployeeImage { Name = "Mark", Image = "../Content/images/EmployeeShiftImage/will-smith.png" });
            employeeImages.Add(new EmployeeImage { Name = "Brian", Image = "../Content/images/EmployeeShiftImage/brian@3x.png" });
            employeeImages.Add(new EmployeeImage { Name = "Kevin", Image = "../Content/images/EmployeeShiftImage/alice.png" });
            employeeImages.Add(new EmployeeImage { Name = "Salman", Image = "../Content/images/EmployeeShiftImage/salman@3x.png" });
            employeeImages.Add(new EmployeeImage { Name = "Emma", Image = "../Content/images/EmployeeShiftImage/emma.png" });
            employeeImages.Add(new EmployeeImage { Name = "Lily", Image = "../Content/images/EmployeeShiftImage/lily.png" });
            employeeImages.Add(new EmployeeImage { Name = "Ava", Image = "../Content/images/EmployeeShiftImage/ava.png" });
            employeeImages.Add(new EmployeeImage { Name = "Grace", Image = "../Content/images/EmployeeShiftImage/grace.png" });
            employeeImages.Add(new EmployeeImage { Name = "Olivia", Image = "../Content/images/EmployeeShiftImage/margaret.png" });
            employeeImages.Add(new EmployeeImage { Name = "Zoe", Image = "../Content/images/EmployeeShiftImage/laura.png" });
            employeeImages.Add(new EmployeeImage { Name = "James", Image = "../Content/images/EmployeeShiftImage/james.png" });
            employeeImages.Add(new EmployeeImage { Name = "Benjamin", Image = "../Content/images/EmployeeShiftImage/benjamin.png" });
            employeeImages.Add(new EmployeeImage { Name = "Olivia", Image = "../Content/images/EmployeeShiftImage/olivia.png" });
            employeeImages.Add(new EmployeeImage { Name = "Chloe", Image = "../Content/images/EmployeeShiftImage/chloe.png" });
            employeeImages.Add(new EmployeeImage { Name = "Ricky", Image = "../Content/images/EmployeeShiftImage/ricky.png" });
            employeeImages.Add(new EmployeeImage { Name = "Jake", Image = "../Content/images/EmployeeShiftImage/jake@3x.png" });

            return employeeImages;

        }
    }
}
