using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.Controllers
{
    [Route("[controller]")]
    public class NotificationController : Controller
    {
        private readonly BlogContext _context;
        private readonly ILogger<NotificationController> _logger;
        private readonly INotificationService _notificationService;

        public NotificationController(ILogger<NotificationController> logger,BlogContext context, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.Identity.Name;
            var notifications = await _notificationService.GetNotificationsAsync(userId);
            ViewBag.Notifications = notifications;
            ViewBag.UnreadNotificationsCount = notifications?.Count(n => !n.IsRead) ?? 0;
            return View(notifications);
        }
        [HttpPost]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null){
                return NotFound();
            }
            notification.IsRead = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}