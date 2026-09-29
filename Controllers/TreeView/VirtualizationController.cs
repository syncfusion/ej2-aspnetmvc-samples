using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        public ActionResult Virtualization()
        {
            TreeViewFieldsSettings virtualFields = new TreeViewFieldsSettings();

            virtualFields.DataSource = GenerateOrganizationData(8000, 20);
            virtualFields.Id = "Id";
            virtualFields.ParentID = "PId";
            virtualFields.Text = "Name";
            virtualFields.HasChildren = "HasChild";
            virtualFields.IsChecked = "IsChecked";
            virtualFields.Expanded = "IsExpanded";

            ViewData["virtualFields"] = virtualFields;

            return View();
        }

        private List<VirtualizationTreeModel> GenerateOrganizationData(int totalNodes, int employeesPerDept)
        {
            List<VirtualizationTreeModel> data = new List<VirtualizationTreeModel>();

            string[] departments =
            {
                "Engineering",
                "Sales",
                "Human Resources",
                "Finance",
                "Marketing",
                "Customer Support",
                "Operations",
                "Legal",
                "Research",
                "IT Infrastructure"
            };

            string[] employeeRoles =
            {
                "Manager",
                "Senior Engineer",
                "Software Engineer",
                "Business Analyst",
                "QA Engineer",
                "Consultant",
                "Specialist",
                "Coordinator",
                "Executive",
                "Associate"
            };

            int index = 0;
            int id = 1;
            int deptIndex = 0;

            while (index < totalNodes)
            {
                int deptId = id++;

                data.Add(new VirtualizationTreeModel
                {
                    Id = deptId,
                    PId = null,
                    Name = departments[deptIndex % departments.Length],
                    HasChild = true,
                    IsChecked = true,
                    IsExpanded = false
                });

                index++;

                for (int i = 0; i < employeesPerDept && index < totalNodes; i++)
                {
                    data.Add(new VirtualizationTreeModel
                    {
                        Id = id++,
                        PId = deptId,
                        Name = employeeRoles[i % employeeRoles.Length] + " - Employee " + (i + 1),
                        HasChild = false,
                        IsChecked = true,
                        IsExpanded = false
                    });

                    index++;
                }

                deptIndex++;
            }

            return data;
        }
    }
}