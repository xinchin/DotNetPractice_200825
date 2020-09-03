using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcServer.Web.Protos;
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

        public override Task<EmployeeResponse> getByNo(GetByNoRequest request, ServerCallContext context)
        {
            return base.getByNo(request, context);
        }
    }
}
