#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EJ2MVCSampleBrowser.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;    
    using EJ2MVCSampleBrowser.Models;

    public static class OrderRepository
    {
        
        public static IList<OrdersDetails> GetAllRecords()
        {
            IList<OrdersDetails> orders = (IList<OrdersDetails>)System.Web.HttpContext.Current.Session["Orders"];

            if (orders == null)
            {
                System.Web.HttpContext.Current.Session["Orders"] = orders = (from ord in OrdersDetails.GetAllRecords()
                                                                  select new OrdersDetails
                                                                  {
                                                                      OrderID = ord.OrderID,
                                                                      OrderDate = ord.OrderDate,
                                                                      CustomerID = ord.CustomerID,
                                                                      EmployeeID = ord.EmployeeID,
                                                                      Freight = ord.Freight,
                                                                      ShipAddress = ord.ShipAddress,
                                                                      ShipCity = ord.ShipCity,
                                                                      ShipName = ord.ShipName,                                                                      
                                                                      ShipCountry = ord.ShipCountry
                                                                  }).ToList();
                foreach (var order in orders)
                {
                    if (order.Freight > 30)
                        order.Verified = true;
                    else
                        order.Verified = false;
                }
            }
            return orders;
        }


        public static void Add(OrdersDetails order)
        {
            GetAllRecords().Insert(0, order);
        }


        public static void Delete(int OrderID)
        {
            OrdersDetails result = GetAllRecords().Where(o => o.OrderID == OrderID).FirstOrDefault();
            GetAllRecords().Remove(result);
        }

        public static void Delete(List<OrdersDetails> order)
        {
            foreach (var temp in order)
            {
                OrdersDetails result = GetAllRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                GetAllRecords().Remove(result);
            }
        }

        public static void Update(OrdersDetails order)
        {
            OrdersDetails result = GetAllRecords().Where(o => o.OrderID == order.OrderID).FirstOrDefault();
            if (result != null)
            {
                result.OrderID = order.OrderID;
                result.OrderDate = order.OrderDate;
                result.CustomerID = order.CustomerID;
                result.EmployeeID = order.EmployeeID;
                result.Freight = order.Freight;
                result.ShipAddress = order.ShipAddress;
                result.ShipCity = order.ShipCity;               
                result.ShipName = order.ShipName;
                result.ShipCountry = order.ShipCountry;
                result.Verified = order.Verified;
            }
        }              

        public static void Update(List<OrdersDetails> order)
        {
            foreach (var temp in order)
            {
                OrdersDetails result = GetAllRecords().Where(o => o.OrderID == temp.OrderID).FirstOrDefault();
                if (result != null)
                {
                    result.OrderID = temp.OrderID;
                    result.OrderDate = temp.OrderDate;
                    result.CustomerID = temp.CustomerID;
                    result.EmployeeID = temp.EmployeeID;
                    result.Freight = temp.Freight;
                    result.ShipAddress = temp.ShipAddress;
                    result.ShipCity = temp.ShipCity;
                    result.ShipName = temp.ShipName;
                    result.ShipCountry = temp.ShipCountry;
                    result.Verified = temp.Verified;
                }
            }
        }
      
    }
}
