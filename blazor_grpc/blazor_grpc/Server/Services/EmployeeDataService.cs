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
                    PhoneNumber = "4053149899",
                    Address = "1011 East Brooks Street Apartment B, Norman, Oklahoma 73071",
                    Notes = "Some random text here to increase the reponse size."
                }
                );

            return Task.FromResult(reply);
        }
    }
}
