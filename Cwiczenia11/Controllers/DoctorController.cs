using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Cwiczenia11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private DoctorsDbContext _context;
        public DoctorController(DoctorsDbContext context)
        {
            _context = context;
        }
        /*
        [HttpGet]
        public void InsertEmployee()
        {
            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s16878;Integrated Security=True"))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                con.Open();

                com.CommandText = "Insert into Doctors (IdDoctor, FirstName, LastName, Email) Values (@id, @firstname, @lastname, @email)";
                com.ExecuteNonQuery();

                com.Parameters.AddWithValue("@id", 2);
                com.Parameters.AddWithValue("@firstname", "Piotr");
                com.Parameters.AddWithValue("@lastname", "Nowak");
                com.Parameters.AddWithValue("@email", "nowak@wp.pl");

            }
        }
        */

        //[HttpGet("{id}")]
        /*
        public IActionResult Update(int id)
        {

            var list = _context.Doctors.First(d => d.IdDoctor == id);
            list.FirstName = "Adam";
            _context.SaveChanges();
            return Ok("Zaktualizowano");
        }
        */
        /*
        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            _context.Remove(_context.Doctors.First(d => d.IdDoctor == id));
            _context.SaveChanges();
            return Ok("Usunięto");
        }
        */
        /*
        [HttpGet("{id}")]
        public IActionResult Return(int id)
        {
            var list = _context.Doctors.First(d => d.IdDoctor == id);
            return Ok(list);
        }
        */

        [HttpPost]
        public IActionResult Insert(Doctor1 doctor)
        {
            Doctor1 d = new Doctor1();    
            d.IdDoctor = doctor.IdDoctor;
            d.FirstName = doctor.FirstName;
            d.LastName = doctor.LastName;
            d.Email = doctor.Email;
            _context.Doctors.Add(d);          
            _context.SaveChanges();

            return Ok("Wstawiono");
        }
    }
}