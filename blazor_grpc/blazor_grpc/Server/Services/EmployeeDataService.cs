using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcEmployeeDataService;

namespace blazor_grpc.Server.Services
{
    public class EmployeeDataService : EmployeeDataSender.EmployeeDataSenderBase
    {
        public override Task<EmployeeListResponse> GetEmployeeData(HelloRequest request, ServerCallContext context)
        {

            var reply = new EmployeeListResponse();

            reply.Employees.Add(
                new EmployeeData()
                {
                    FirstName = "Akshay",
                    LastName = "Gaur",
                    PhoneNumber = "(405) xxx-xxxx",
                    Address = "9999 East Alameda Street Apartment XYZ, Norman, Oklahoma 73069",
                    Notes = "Some random text here to increase the reponse size. Should probably make it longer."
                }
                );

            return Task.FromResult(reply);
        }
    }
}
