//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Mod8WCFDataService
{
    public class FourthCoffeeDataService : DataService<FourthCoffeeEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("AllEmployees", ServiceOperationRights.All);
            config.SetServiceOperationAccessRule("EmployeesByID", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [WebGet]
        public IQueryable<Employees> AllEmployees()
        {
            return from e in this.CurrentDataSource.Employees select e;
        }

        [WebGet]
        public IQueryable<Employees> EmployeesByID(int id)
        {
            return this.CurrentDataSource.Employees.Where(e => e.EmployeeID == id);
        }
    }
}
