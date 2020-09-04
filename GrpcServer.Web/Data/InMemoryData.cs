using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcServer.Web.Protos;

namespace GrpcServer.Web.Data
{
    public class InMemoryData
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee{
                Id =1,
                No=1977,
                Firstname="Nelson",
                Lastname="Huang",
                Salary=1000000
            },
            new Employee{
                Id =2,
                No=1978,
                Firstname="Xinchin",
                Lastname="Huang",
                Salary=1000000
            },
            new Employee{
                Id =3,
                No=1979,
                Firstname="Nelson Huang",
                Lastname="Huang",
                Salary=1000000
            },

        };
    }
}
