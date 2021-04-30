
using System.ComponentModel.DataAnnotations;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    //
    // Riepilogo:
    //     The push message urgency.
    public enum MessageUrgency
    {
        //
        // Riepilogo:
        //     Very low (e.g. advertisements).
        VeryLow = 0,
        //
        // Riepilogo:
        //     Low (e.g. topic updates).
        Low = 1,
        //
        // Riepilogo:
        //     Normal (e.g. chat message).
        Normal = 2,
        //
        // Riepilogo:
        //     High (e.g. time-sensitive alert).
        High = 3
    }
    public class ApiWebPushNotification
    {
        [Key] public int Id { get; set; }
        [Required] public string Topic { get; set; }
        [Required] public string Notification { get; set; }
        [Required] public MessageUrgency Urgency { get; set; } = MessageUrgency.Normal;
    }
}
