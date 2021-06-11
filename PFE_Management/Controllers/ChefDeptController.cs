using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PFE_Management.Data;
using PFE_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFE_Management.Controllers
{
    [Authorize(Roles = "Chef_Departement")]
    public class ChefDeptController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChefDeptController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int ? id)
        {
            var applicationDbContext = _context.Stages;
            if(id != null)
            {
                var stageToValidate = await _context.Stages

                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
                stageToValidate.EtatStage = true;
                await _context.SaveChangesAsync();

                return View(await applicationDbContext.ToListAsync());
            }

            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> DetailsStage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stage = await _context.Stages

                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stage == null)
            {
                return NotFound();
            }

            return View(stage);
        }

        //valider stage :
        public async Task<IActionResult> ValiderStage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //update etat de stage 
            var stageToValidate = await _context.Stages
               .FirstOrDefaultAsync(m => m.Id == id);
            stageToValidate.EtatStage = true;


                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                
        }

        // invalider (etat de stage 
        public async Task<IActionResult> InValiderStage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //update etat de stage 
            var stageToValidate = await _context.Stages
               .FirstOrDefaultAsync(m => m.Id == id);
            stageToValidate.EtatStage = false;


            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        // Supprimer un stage par le chef de departement 
        public async Task<IActionResult> SupprimerStage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //supprimer etat de stage 

            if (await _context.Stages.AnyAsync(m => m.Id == id))
            {
                var stageToDelete = await _context.Stages
               .FirstOrDefaultAsync(m => m.Id == id);

                _context.Stages.Remove(stageToDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));

        }

    }
}
