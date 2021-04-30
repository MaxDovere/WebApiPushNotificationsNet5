
using System;
using System.Collections.Generic;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    public class ApiWebPushMessageAction
    {
        public string Action { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        
        public ApiWebPushMessageAction(string action, string title, string icon)
        {
            this.Action = action;
            this.Title = title;
            this.Icon = icon;
        }
    }

    public class ApiWebPushMessagesImage : ApiWebPushMessages
    {
        public string Badge { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        
    }

    public class ApiWebPushMessages
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public ApiWebPushMessageAction[] Actions { get; set; }
        public bool RequireInteraction { get; set; } = true;
        public int[] Vibrate { get; set; } = new int[] { 100, 50, 100 };
        public DateTime? TimeStamp { get; set; } = DateTime.UtcNow;
        public string Dir { get; set; } = "auto";
        public string Lang { get; set; } = "en";
        public string Tag { get; set; }
        public object Data { get; set; }
        public bool? Renotify { get; set; }
        public bool? Silent { get; set; }
        public string Sound { get; set; }
        public bool? NoScreen { get; set; }
        public bool? Sticky { get; set; }
        public int? TimeOut { get; set; } = 5;

    }
}
