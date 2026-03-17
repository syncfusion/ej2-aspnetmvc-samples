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
using System.Web.Hosting;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Newtonsoft.Json;
using System.IO;
//File Manager's base functions are available in the below package
using Syncfusion.EJ2.FileManager.Base;
//File Manager's operations are available in the below package
using Syncfusion.EJ2.FileManager.PhysicalFileProvider;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class FileManagerController : Controller
    {
        // Accessing the File Operations from File Manager package
        PhysicalFileProvider operation = new PhysicalFileProvider();
        public string basePath;
        public FileManagerController()
        {
            // Map the path of the files to be accessed with the host
            this.basePath = HostingEnvironment.MapPath("~/Content/images/FileManager");
            // Assign the mapped path as root folder
            operation.RootFolder(this.basePath);
        }
        public ActionResult FileOperations(FileManagerDirectoryContent args)
        {
            // Restricting modification of the root folder
            if (args.Action == "delete" || args.Action == "rename")
            {
                if ((args.TargetPath == null) && (args.Path == ""))
                {
                    FileManagerResponse response = new FileManagerResponse();
                    ErrorDetails er = new ErrorDetails
                    {
                        Code = "401",
                        Message = "Restricted to modify the root folder."
                    };
                    response.Error = er;
                    return Json(operation.ToCamelCase(response));
                }
            }
            // Processing the File Manager operations
            switch (args.Action)
            {
                case "read":
                    // Path - Current path; ShowHiddenItems - Boolean value to show/hide hidden items
                    return Json(operation.ToCamelCase(this.operation.GetFiles(args.Path, args.ShowHiddenItems)));
                case "delete":
                    // Path - Current path where of the folder to be deleted; Names - Name of the files to be deleted
                    return Json(operation.ToCamelCase(this.operation.Delete(args.Path, args.Names)));
                case "copy":
                    //  Path - Path from where the file was copied; TargetPath - Path where the file/folder is to be copied; RenameFiles - Files with same name in the copied location that is confirmed for renaming; TargetData - Data of the copied file
                    return Json(operation.ToCamelCase(this.operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "move":
                    // Path - Path from where the file was cut; TargetPath - Path where the file/folder is to be moved; RenameFiles - Files with same name in the moved location that is confirmed for renaming; TargetData - Data of the moved file
                    return Json(operation.ToCamelCase(this.operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "details":
                    // Path - Current path where details of file/folder is requested; Name - Names of the requested folders
                    if (args.Names == null)
                    {
                        args.Names = new string[] { };
                    }
                    return Json(operation.ToCamelCase(this.operation.Details(args.Path, args.Names, args.Data)));
                case "create":
                    // Path - Current path where the folder is to be created; Name - Name of the new folder
                    return Json(operation.ToCamelCase(this.operation.Create(args.Path, args.Name)));
                case "search":
                    // Path - Current path where the search is performed; SearchString - String typed in the searchbox; CaseSensitive - Boolean value which specifies whether the search must be casesensitive
                    return Json(operation.ToCamelCase(this.operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive)));
                case "rename":
                    // Path - Current path of the renamed file; Name - Old file name; NewName - New file name
                    return Json(operation.ToCamelCase(this.operation.Rename(args.Path, args.Name, args.NewName)));
            }
            return null;
        }
        // Processing the Upload operation
        public ActionResult Upload(string path, IList<System.Web.HttpPostedFileBase> uploadFiles, string action)
        {
            try
            {
                // Here we have restricted the upload operation for our online samples
                if (Request.Url.Authority == "ej2.syncfusion.com")
                {
                    HttpResponse Response = System.Web.HttpContext.Current.Response;
                    Response.Clear();
                    Response.ContentType = "application/json; charset=utf-8";
                    Response.StatusCode = 403;
                    Response.StatusDescription = "File Manager's upload functionality is restricted in the online demo. If you need to test upload functionality, please install Syncfusion Essential Studio on your machine and run the demo";
                    Response.End();
                }
                // Use below code for performing upload operation
                else
                {
                    FileManagerResponse uploadResponse;
                    foreach (var file in uploadFiles)
                    {
                        var folders = (file.FileName).Split('/');
                        // checking the folder upload
                        if (folders.Length > 1)
                        {
                            for (var i = 0; i < folders.Length - 1; i++)
                            {
                                string newDirectoryPath = Path.Combine(this.basePath + path, folders[i]);
                                if (Path.GetFullPath(newDirectoryPath) != (Path.GetDirectoryName(newDirectoryPath) + Path.DirectorySeparatorChar + folders[i]))
                                {
                                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                                }
                                if (!Directory.Exists(newDirectoryPath))
                                {
                                    this.operation.ToCamelCase(this.operation.Create(path, folders[i]));
                                }
                                path += folders[i] + "/";
                            }
                        }
                    }
                    // Invoking upload operation with the required paramaters
                    // path - Current path where the file is to uploaded; uploadFiles - Files to be uploaded; action - name of the operation(upload)
                    uploadResponse = operation.Upload(path, uploadFiles, action, null);
                }
                return Content("");
            }
            catch (Exception e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                er.Message = "Access denied for Directory-traversal";
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.StatusCode = Convert.ToInt32(er.Code);
                return Content("");
            }
        }
        // Processing the Download operation
        public ActionResult Download(string downloadInput)
        {
            FileManagerDirectoryContent args = JsonConvert.DeserializeObject<FileManagerDirectoryContent>(downloadInput);
            //Invoking download operation with the required paramaters
            // path - Current path where the file is downloaded; Names - Files to be downloaded;
            return operation.Download(args.Path, args.Names);
        }
        // Processing the GetImage operation
        public ActionResult GetImage(FileManagerDirectoryContent args)
        {
            //Invoking GetImage operation with the required paramaters
            // path - Current path of the image file; Id - Image file id;
            return operation.GetImage(args.Path, args.Id, false, null, null);
        }
    }
}
