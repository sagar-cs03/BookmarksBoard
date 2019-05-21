using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Pinboard.Models;

namespace Pinboard.Controllers
{
    public class SessionCheck : ActionFilterAttribute
    {
        public Boolean AllowIfLoggedIn { get; set; }

        public SessionCheck()
        {
            AllowIfLoggedIn = true;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
                
            String isUserLoggedIn = filterContext.HttpContext.Session.GetString("isUserLoggedIn");

            if (AllowIfLoggedIn == true && isUserLoggedIn != "True")
            {
                filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary {
                        { "Controller", "User" },
                        { "Action", "Login" }
                                    });
            }
            else if (AllowIfLoggedIn == false && isUserLoggedIn == "True")
            {
                filterContext.Result = new RedirectToRouteResult(
                     new RouteValueDictionary {
                        { "Controller", "Dashboard" },
                        { "Action", "Index" }
                                 });
            }

        }
    }


    public class BookmarksController : Controller
    {
        private readonly PinboardContext _context;

        public BookmarksController(PinboardContext context)
        {
            _context = context;
        }

        // GET: Bookmarks
        [SessionCheck]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bookmarks.ToListAsync());
        }

        // GET: Bookmarks/Details/5
        [SessionCheck]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookmark = await _context.Bookmarks
                .FirstOrDefaultAsync(m => m.BookmarkID == id);
            if (bookmark == null)
            {
                return NotFound();
            }

            return View(bookmark);
        }

        // GET: Bookmarks/Create
        [SessionCheck]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookmarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [SessionCheck]
        public async Task<IActionResult> Create([Bind("BookmarkID,URL,Title,Description,Tags,IsReadLater")] Bookmark bookmark)
        {
            if (ModelState.IsValid)
            {
                if (bookmark.Tags != "")
                {
                    bookmark.IsTagged = false;
                }

                bookmark.IsStarred = false;
                bookmark.DateAndTimeCreated = DateTime.Now;

                _context.Add(bookmark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookmark);
        }

        // GET: Bookmarks/Edit/5
        [SessionCheck]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookmark = await _context.Bookmarks.FindAsync(id);
            if (bookmark == null)
            {
                return NotFound();
            }
            return View(bookmark);
        }

        // POST: Bookmarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [SessionCheck]
        public async Task<IActionResult> Edit(string id, [Bind("BookmarkID,URL,Title,Description,Tags,IsReadLater,IsStarred,IsTagged,DateAndTimeCreated")] Bookmark bookmark)
        {
            if (id != bookmark.BookmarkID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookmark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookmarkExists(bookmark.BookmarkID))
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
            return View(bookmark);
        }

        // GET: Bookmarks/Delete/5
        [SessionCheck]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookmark = await _context.Bookmarks
                .FirstOrDefaultAsync(m => m.BookmarkID == id);
            if (bookmark == null)
            {
                return NotFound();
            }

            return View(bookmark);
        }

        // POST: Bookmarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [SessionCheck]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var bookmark = await _context.Bookmarks.FindAsync(id);
            _context.Bookmarks.Remove(bookmark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [SessionCheck]
        private bool BookmarkExists(string id)
        {
            return _context.Bookmarks.Any(e => e.BookmarkID == id);
        }
    }
}
