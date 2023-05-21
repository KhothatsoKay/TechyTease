
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

public interface INotificationService{
    Task AddNotificationAsync(Notification notification);
    Task<IEnumerable<Notification>> GetNotificationsAsync(string userId); 
}
public class NotificationService : INotificationService
{
    private readonly BlogContext _context;
    public NotificationService(BlogContext context)
    {
        _context = context;
    }
    public async Task AddNotificationAsync(Notification notification)
    {
        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Notification>> GetNotificationsAsync(string userId)
    {
        var blogIds = await _context.Blogs
        .Where(b => b.AuthorName == userId)
        .Select(b => b.Id)
        .ToListAsync();
        var notifications = await _context.Notifications
        .Where(n => blogIds.Contains(n.BlogId))
        .OrderByDescending(n => n.CreatedAt)
        .ToListAsync();
        return notifications;
    }
}