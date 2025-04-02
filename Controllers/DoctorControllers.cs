using HospitalsWeb.cs.Models.Context;
using HospitalsWeb.cs.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalsWeb.cs.Controllers
{
    public class DoctorControllers : Controller
    {
        public readonly MyContext _mycontext;

        public DoctorControllers(MyContext mycontext)
        {
            _mycontext = mycontext;

        }
        public async Task<IActionResult> Index()
        { 
            return View(await _mycontext.Doctors.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var result = await _mycontext.Doctors.Where(x => x.DoctorId == id).ToListAsync();
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        // GET: DoctorControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Doctor doctor)
        {
            try
            {     
                _mycontext.Doctors.Add(doctor); 
                await _mycontext.SaveChangesAsync();   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorControllers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Doctor doctor)
        {
            try
            {

                var result = await _mycontext.Doctors.FindAsync(id);
                if(result != null)
                {
                    _mycontext.Doctors.Update(doctor);
                    await _mycontext.SaveChangesAsync(); 
                    return RedirectToAction(nameof(Index)); 
                } else
                {
                    return NotFound();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
