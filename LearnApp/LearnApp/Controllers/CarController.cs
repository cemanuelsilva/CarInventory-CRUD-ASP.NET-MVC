using LearnApp.Data;
using LearnApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnApp.Controllers
{
    [Route("Car")] // Adjusted to fit typical MVC routing
    public class CarController : Controller
    {
        private readonly DataContext _context;

        public CarController(DataContext context)
        {
            _context = context;
        }


        // GET: /Car/AllCars
        [HttpGet("allCars")]
        public async Task<IActionResult> GetAllCars()
        {
            var carsList = await _context.Car.ToListAsync();

            return View("Index", carsList); // Return the GetAllCars view with the list
        }

        // GET: /Car/CreateCar
        [HttpGet("CreateCar")]
        public IActionResult CreateCar()
        {
            return View("Create"); // Render the form for creating a car
        }

        // POST: /Car/CreateCar
        [HttpPost("CreateCar")]
        public async Task<IActionResult> CreateCar(Car carCreated)
        {
            if (!ModelState.IsValid)
            {
                return View(carCreated); // Return view with validation errors
            }

            _context.Add(carCreated);
            await _context.SaveChangesAsync();

            return RedirectToAction("allCars"); // Redirect to the Index action after creation
        }


        [HttpPost()]
        public async Task<IActionResult> DeleteCar(string plateGiven)
        {
            var carToDelete = await _context.Car.FirstOrDefaultAsync(c => c.plate == plateGiven);

            if (carToDelete == null)
            {
                return View("Error", new { message = "Car not found" });
            }

            _context.Car.Remove(carToDelete);
            await _context.SaveChangesAsync();

            return RedirectToAction("allCars"); // Redirect to the Index action or wherever you list the cars
        }

        [HttpGet("updateCar")]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            return View("Update", car); // Pass the car data to the Edit view
        }


        // POST: /Car/UpdateCar
        [HttpPost("updateCar")]
        public async Task<IActionResult> UpdateCar(Car updatedCar)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", updatedCar); // Return to the Edit view with validation errors
            }

            var existingCar = await _context.Car.FindAsync(updatedCar.carId);
            if (existingCar == null)
            {
                return NotFound();
            }

            _context.Entry(existingCar).CurrentValues.SetValues(updatedCar);
            await _context.SaveChangesAsync();

            return RedirectToAction("allCars"); // Redirect to the Index page or another appropriate page
        }




    }
}
