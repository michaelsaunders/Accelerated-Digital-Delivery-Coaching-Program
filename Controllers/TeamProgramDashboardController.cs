using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accelerated_Digital_Delivery_Coaching_Program.ViewModels;
using Accelerated_Digital_Delivery_Coaching_Program.Models;

namespace Accelerated_Digital_Delivery_Coaching_Program.Controllers
{
    public class TeamProgramDashboardController : Controller
    {

        private readonly AddDBContext _context;

        public TeamProgramDashboardController(AddDBContext context)
        {
            _context = context;
        }

        // GET: TeamProgramDashboard
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamProgramDashboard/GetBoard/5
        public async Task<IActionResult> GetBoard(int id)
        {

            Guid obj = Guid.NewGuid();

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.TeamID == id);
            if (team == null)
            {
                return NotFound();
            }
            
            var iteration = await _context.Iterations.Where(m => m.TeamID == id).Include(p => p.IterationGoal).ToListAsync();

            
            var programincrementgoals = await _context.ProgramIncrementGoal.Where(m => m.TeamID == id).ToListAsync();
            //    .FirstOrDefaultAsync(m => m.TeamID == id);
            
            TeamProgramDashboard teamprogramdashboard = new TeamProgramDashboard { Team = team, Iterations = iteration, ProgramIncrementGoals = programincrementgoals};

            if (programincrementgoals == null)
            {
                return NotFound();
            }

            return View(teamprogramdashboard);
        }


    }
}
