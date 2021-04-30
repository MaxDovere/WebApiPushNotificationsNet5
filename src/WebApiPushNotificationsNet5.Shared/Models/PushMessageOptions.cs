using System;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    public class PushMessageOptions
    {
        public PushMessageType MessageType { get; set; }
        public string Url { get; set; }
        public string Vibrate { get; set; }
        public DateTime? TimeStamp { get; set; } = DateTime.UtcNow;
        public string Dir { get; set; } = "auto";
        public string Lang { get; set; } = "en";
        public string Body { get; set; }
        public string Tag { get; set; }
        public string Badge { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public object Data { get; set; }
        public bool? Renotify { get; set; }
        public bool? RequireInteraction { get; set; }
        public bool? Silent { get; set; }
        public string Sound { get; set; }
        public bool? NoScreen { get; set; }
        public bool? Sticky { get; set; }
        public int? TimeOut { get; set; } = 5;
    }
}
