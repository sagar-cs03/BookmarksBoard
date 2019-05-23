using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pinboard.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Pinboard.Controllers
{
    public class SearchController : Controller
    {
        private readonly PinboardContext _Context;

        public SearchController(PinboardContext context)
        {
            _Context = context;
        }

        public async Task<IActionResult> Index(String Tags, String SearchInAction, String SearchInAll, String SearchInUnread, String SearchInStarred)
        {
            if (string.IsNullOrEmpty(Tags))
            {

                if (!string.IsNullOrEmpty(SearchInAction))
                {
                    return View(await _Context.Bookmarks.ToListAsync());
                }
                else if (!string.IsNullOrEmpty(SearchInAll))
                {
                    return RedirectToAction("Index", "Search");
                }
                else if (!string.IsNullOrEmpty(SearchInStarred))
                {
                    return RedirectToAction("Starred", "Search");

                }
                else if (!string.IsNullOrEmpty(SearchInUnread))
                {
                    return RedirectToAction("Unread", "Search");
                }
                else
                {
                    return View(await _Context.Bookmarks.ToListAsync());
                }
            }
            else
            {


                return View(await _Context.Bookmarks.Where(b => b.Tags == Tags).ToListAsync());
                //    Tags = Tags.Trim();
                //    var regex = new Regex(@"(?<=#)\w+");
                //    var matches = regex.Matches(Tags);
                //    List<String> all_tags = new List<String>();

                //    foreach(Match match in matches)
                //    {
                //        Console.WriteLine(match.Value);
                //        all_tags.Add(match.Value);
                //    }

                //    var results =  _Context.Bookmarks.Where(b => all_tags.Contains(b.Tags));


                //    if (!string.IsNullOrEmpty(SearchInAction))
                //    {
                //        return View(await results.ToListAsync());
                //    }
                //    else if (!string.IsNullOrEmpty(SearchInAll))
                //    {
                //        return View(await results.ToListAsync());
                //    }
                //    else if (!string.IsNullOrEmpty(SearchInStarred))
                //    {
                //        results =  results.Where(b => b.IsStarred == true);
                //        return View("Starred", await results.ToListAsync());
                //    }
                //    else if(!string.IsNullOrEmpty(SearchInUnread))
                //    {
                //        results = results.Where(b => b.IsReadLater == true);
                //        return View("Unread", await results.ToListAsync());
                //    } else
                //    {
                //        return View(await _Context.Bookmarks.ToListAsync());
                //    }
            }

        }


        public async Task<IActionResult> Unread(String Tags, String SearchInAction, String SearchInAll, String SearchInUnread, String SearchInStarred)
        {
            if (string.IsNullOrEmpty(Tags))
            {

                if (!string.IsNullOrEmpty(SearchInAction))
                {
                    return View(await _Context.Bookmarks.Where(b => b.IsReadLater == true).ToListAsync());
                }
                else if (!string.IsNullOrEmpty(SearchInAll))
                {
                    return RedirectToAction("Index", "Search");
                }
                else if (!string.IsNullOrEmpty(SearchInStarred))
                {
                    return RedirectToAction("Starred", "Search");

                }
                else if (!string.IsNullOrEmpty(SearchInUnread))
                {
                    return RedirectToAction("Unread", "Search");
                }
                else
                {
                    return View(await _Context.Bookmarks.Where(b => b.IsReadLater == true).ToListAsync());
                }
            }
            else
            {

                return View(await _Context.Bookmarks.Where(b => b.Tags == Tags && b.IsReadLater == true).ToListAsync());
                //    Tags = Tags.Trim();
                //    var regex = new Regex(@"(?<=#)\w+");
                //    var matches = regex.Matches(Tags);
                //    List<String> all_tags = new List<String>();

                //    foreach (Match match in matches)
                //    {
                //        Console.WriteLine(match.Value);
                //        all_tags.Add(match.Value);
                //    }

                //    var results = _Context.Bookmarks.Where(b => all_tags.Contains(b.Tags));


                //    if (!string.IsNullOrEmpty(SearchInAction))
                //    {
                //        return View(await results.ToListAsync());
                //    }
                //    else if (!string.IsNullOrEmpty(SearchInAll))
                //    {
                //        return View(await results.ToListAsync());
                //    }
                //    else if (!string.IsNullOrEmpty(SearchInStarred))
                //    {
                //        results = results.Where(b => b.IsStarred == true);
                //        return View("Starred", await results.ToListAsync());
                //    }
                //    else if (!string.IsNullOrEmpty(SearchInUnread))
                //    {
                //        results = results.Where(b => b.IsReadLater == true);
                //        return View("Unread", await results.ToListAsync());
                //    }
                //    else
                //    {
                //        return View(await _Context.Bookmarks.ToListAsync());
                //    }
            }
        }

        public async Task<IActionResult> Starred(String Tags, String SearchInAction, String SearchInAll, String SearchInUnread, String SearchInStarred)
        {
            if (string.IsNullOrEmpty(Tags))
            {

                if (!string.IsNullOrEmpty(SearchInAction))
                {
                    return View(await _Context.Bookmarks.Where(b => b.IsStarred == true).ToListAsync());
                }
                else if (!string.IsNullOrEmpty(SearchInAll))
                {
                    return RedirectToAction("Index", "Search");
                }
                else if (!string.IsNullOrEmpty(SearchInStarred))
                {
                    return RedirectToAction("Starred", "Search");

                }
                else if (!string.IsNullOrEmpty(SearchInUnread))
                {
                    return RedirectToAction("Unread", "Search");
                }
                else
                {
                    return View(await _Context.Bookmarks.Where(b => b.IsStarred == true).ToListAsync());
                }
            }
            else
            {
                return View(await _Context.Bookmarks.Where(b => b.Tags == Tags && b.IsStarred == true).ToListAsync());

                //        Tags = Tags.Trim();
                //        var regex = new Regex(@"(?<=#)\w+");
                //        var matches = regex.Matches(Tags);
                //        List<String> all_tags = new List<String>();

                //        foreach (Match match in matches)
                //        {
                //            Console.WriteLine(match.Value);
                //            all_tags.Add(match.Value);
                //        }

                //        var results = _Context.Bookmarks.Where(b => all_tags.Contains(b.Tags));


                //        if (!string.IsNullOrEmpty(SearchInAction))
                //        {
                //            return View(await results.ToListAsync());
                //        }
                //        else if (!string.IsNullOrEmpty(SearchInAll))
                //        {
                //            return View(await results.ToListAsync());
                //        }
                //        else if (!string.IsNullOrEmpty(SearchInStarred))
                //        {
                //            results = results.Where(b => b.IsStarred == true);
                //            return View("Starred", await results.ToListAsync());
                //        }
                //        else if (!string.IsNullOrEmpty(SearchInUnread))
                //        {
                //            results = results.Where(b => b.IsReadLater == true);
                //            return View("Unread", await results.ToListAsync());
                //        }
                //        else
                //        {
                //            return View(await _Context.Bookmarks.Where(b => b.IsStarred == true).ToListAsync());
                //        }
                //    }
                //
            }

        }
    }
}
            