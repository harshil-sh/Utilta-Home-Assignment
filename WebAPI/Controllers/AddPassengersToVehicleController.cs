using Domain.Models;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        IVehicleService _vehicleService;

        public AddPassengersToVehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToCar(int number)
        {
            /*try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new Car().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
            try
            {
                Car car=_vehicleService.AddPassengerToCar(number);
                return Ok();
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToMotorBike(int number)
        {
            /*try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new MotorBike().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
            try
            {
                MotorBike motorBike = _vehicleService.AddPassengerToMotorBike(number);
                return Ok();
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToCoach(int number)
        {
            /*try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new Coach().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }*/
            try
            {
                Coach coach=_vehicleService.AddPassengerToCoach(number);
                return Ok();
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
