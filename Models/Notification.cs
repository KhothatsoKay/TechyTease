using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Notification
    {
    public int Id { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
    public string UserId { get; set; }
    public int BlogId {get; set;}
    public NotificationType NotificationType {get; set;}

}
public enum NotificationType {
    BlogCreated,
    BlogRated
}
}