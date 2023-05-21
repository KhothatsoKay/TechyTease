using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using System.Security.Claims;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Differencing;
using System.Diagnostics;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly BlogContext _context;
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly INotificationService _notificationService;


        public BlogController(BlogContext context, UserManager<ApplicationUser> userManager, IFileProvider fileProvider, IHostingEnvironment env,
        INotificationService notificationService)
        {
            _context = context;
            fileProvider = fileProvider;
            hostingEnvironment = env;
            _userManager = userManager;
            _notificationService = notificationService;

        }



        // GET: Blog
        public async Task<IActionResult> Index(string search)
        {
            var userId = User.Identity.Name;
            var notifications = await _notificationService.GetNotificationsAsync(userId);
            ViewBag.Notifications = notifications;
            ViewBag.UnreadNotificationsCount = notifications?.Count(n => !n.IsRead) ?? 0;
            var blog = _context.Blogs.Include(b => b.User).
            Include(b => b.Reactions).ThenInclude(r => r.User).
            Where(b => string.IsNullOrEmpty(search) || b.Title.Contains(search) || b.Content.Contains(search) || b.AuthorName
            .Contains(search)).
            Select(b => new BlogModel
            {
                Id = b.Id,
                Title = b.Title,
                Content = b.Content,
                ImagePath = b.ImagePath,
                AuthorName = b.AuthorName,
                Created = b.Created,
                AuthorProfilePicture = b.AuthorProfilePicture,
                Reactions = b.Reactions.Select(r => new Reaction
                {
                    Id = r.Id,
                    Value = r.Value,
                    reactor = r.reactor,
                    Comment = r.Comment,

                }).
                ToList()
            }).OrderByDescending(b => b.Created)
            .ToList();

            return View(blog);
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.Reactions) // Include the "Reactions" property
                .FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Reaction(int blogId, string value, string comment)
        {


            var blog = _context.Blogs.Include(b => b.Reactions).FirstOrDefault(b => b.Id == blogId);
            var currentUser = await _userManager.GetUserAsync(User);


            if (blog == null)
            {
                return NotFound();
            }
            var reaction = new Reaction
            {
                Value = value,
                Comment = comment,
                Blog = blog,
                reactor = currentUser.UserName

            };
            _context.Reactions.Add(reaction);
            _context.SaveChanges();
            var notification = new Notification
            {
                Message = $"Your blog '{blog.Title}' has received a new reaction",
                CreatedAt = DateTime.Now,
                BlogId = blogId,
                UserId = User.Identity.Name,
                NotificationType = NotificationType.BlogRated
            };
            await _notificationService.AddNotificationAsync(notification);

            return RedirectToAction("Index", new { id = blog.Id });
        }


        // GET: Blog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Created,ImagePath")] BlogModel blogModel, IFormFile file)
        {
            if (ModelState.IsValid)
            {

                blogModel.Created = DateTime.Now;


                var regex = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                blogModel.Content = regex.Replace(blogModel.Content, match => $"<a href=\"{match.Value}\">{match.Value}</a>");
                blogModel.AuthorName = User.Identity.Name;
                var user = await _userManager.GetUserAsync(User);
                blogModel.AuthorProfilePicture = user.ProfilePicture;
                _context.Blogs.Add(blogModel);
                await _context.SaveChangesAsync();


                var timeElapsed = DateTime.Now - blogModel.Created;
                if (timeElapsed.TotalHours >= 42)
                {
                    blogModel.Created = blogModel.Created.Date.AddDays(-(int)blogModel.Created.DayOfWeek);
                }
                else if (timeElapsed.TotalHours >= 24)
                {
                    blogModel.Created = blogModel.Created.AddDays(-1);
                }

                if (file != null || file.Length != 0)
                {
                    FileInfo fi = new FileInfo(file.FileName);
                    var newFilename = blogModel.Id + "_" + String.Format("{0:d}", (DateTime.Now.Ticks / 10) % 1000000) + fi.Extension;
                    var webPath = hostingEnvironment.WebRootPath;
                    var path = Path.Combine("", webPath + @"\Images\" + newFilename);
                    var pathToSave = @"\Images\" + newFilename;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    blogModel.ImagePath = pathToSave;
                    _context.Update(blogModel);
                    await _context.SaveChangesAsync();
                }
                else
                {

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(blogModel);
        }


        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogModel = await _context.Blogs.FindAsync(id);
            if (blogModel == null)
            {
                return NotFound();
            }
            return View(blogModel);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,Created,ImagePath")] BlogModel blogModel)
        {
            if (id != blogModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogModelExists(blogModel.Id))
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
            return View(blogModel);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogModel = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogModel == null)
            {
                return NotFound();
            }

            return View(blogModel);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogModel = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blogModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogModelExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }



    }
}

