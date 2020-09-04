using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcServer.Web.Protos;
using GrpcServer.Web.Data;
using Microsoft.Extensions.Logging;


namespace GrpcServer.Web.Services
{
    public class MyEmployeeService :EmployeeService.EmployeeServiceBase
    {

        private readonly ILogger<MyEmployeeService> _logger;

        public MyEmployeeService(ILogger<MyEmployeeService> logger)
        {
            _logger = logger;
        }

        public override Task<EmployeeResponse> GetByNo(GetByNoRequest request, ServerCallContext context)
        {
            var employee = InMemoryData.Employees.SingleOrDefault(x => x.No == request.No);
            if (null != employee)
            {
                var response = new EmployeeResponse {
                    Employee = employee
                };
                return Task.FromResult(response);
            }

            throw new Exception("...error...");
        }
    }
}
