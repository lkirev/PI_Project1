using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PI_Project.Data;
using PI_Project.Models;


namespace PI_Project.Controllers
{
    public class UsersController : Controller
    {
        private readonly PI_ProjectContext _context;

        public UsersController(PI_ProjectContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            //ViewData["Error"] = "false";
            return View(await _context.User.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Login(string uname, string psw)
        //public async Task<IActionResult> Login([Bind("Name,Pass")] User user)
        {
            //bool login = false;
            /*
            User[] users = new User[5];

            for(int i = 0; i<=users.Length; i++)
            {
                users[i] = await _context.User.FirstOrDefaultAsync(m => m.Id == i);
            }

            string foundUsername = "";
                
            for(int i = 0; i<= users.Length; i++)
            {
                if (users[i].Name.Equals(uname))
                {
                    foundUsername = users[i].Name;
                }
            }*/

            //var user = _context.User.Where(m => m.Name == uname).Select(m => m.Name).SingleOrDefault();

            List<User> users = _context.User.ToList();

            foreach(var User in users)
            {
                /*                System.Diagnostics.Debug.WriteLine("username: " + User.Name);
                                System.Diagnostics.Debug.WriteLine("pass: " + User.Pass);*/

                if (User.Name.Equals(uname) && User.Pass.Equals(psw))
                {
                    return RedirectToAction("Index", "Parts");
                }
            }


            //var user = await _context.User.FirstOrDefaultAsync(m => m.Name.Equals(uname));
            //System.Diagnostics.Debug.WriteLine("username: " + user);

            //var user = await _context.User.FirstAsync(m => m.Name.Equals(uname));

            //var user = (User)(typeof([User]).GetProperty(Name).GetValue(uname, null));

            //System.Diagnostics.Debug.WriteLine("login func hash is: " + MyHash.Hash(psw));

            /*if (user.Pass.Equals(MyHash.Hash(psw)))
            {
                login = true;
                System.Diagnostics.Debug.WriteLine("logged in");
            }
            else
            {
                ViewData["Error"] = "true";
            }

            //if (_context.User.FirstOrDefaultAsync(m => m.Name.Equals(uname)) && _context.User.FirstOrDefaultAsync(m => m.Pass.Equals(MyHash.Hash(psw))))
            //{

            //}*/

            //if (login) { return View(); } else { return View(user); }

            //ViewData["Error"] = true;

            return RedirectToAction("Index");
            
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Pass")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Pass")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
