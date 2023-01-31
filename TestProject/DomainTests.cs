using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using WebApplication1.Controllers;
using Moq;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Domain.Repository;
using Domain.Service;

namespace TestProject
{
    public class DomainTests
    {
        private IVehicleService _vehicleService;
        private AddPassengersToVehicleController _controller;
       
        public DomainTests() 
        {
            _controller = new AddPassengersToVehicleController(_vehicleService);
            
        }

        [Fact]
        public void AddPassengersToCar()
        {
            //AddPassengersToVehicleController controller=new AddPassengersToVehicleController()
            IActionResult actionResult = _controller.AddPassengersToCar(1);
            Assert.IsType<OkResult>(actionResult as OkResult);
        }
        [Fact]
        public void AddPassengersToMotorBike()
        {
            //AddPassengersToVehicleController controller=new AddPassengersToVehicleController()
            IActionResult actionResult = _controller.AddPassengersToMotorBike(1);
            Assert.IsType<OkResult>(actionResult as OkResult);
        }
        [Fact]
        public void AddPassengersToCoach()
        {
            //AddPassengersToVehicleController controller=new AddPassengersToVehicleController()
            IActionResult actionResult = _controller.AddPassengersToCoach(1);
            Assert.IsType<OkResult>(actionResult as OkResult);
        }


    }
}
