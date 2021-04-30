using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    public class PushMessagesTemplate
    {
        [Key] public int MessageId { get; set; }
        [Required] public PushMessageType MessageType { get; set; }
        public string Url { get; set; }
        public string Vibrate { get; set; }
        /// <summary>
        /// Defines a title for the notification, which will be shown at the top of the notification window when it is fired.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// A <see cref="DateTime"/> representing the time, in milliseconds since 00:00:00 UTC on 1 January 1970, of the event for which the notification was created.
        /// </summary>
        public DateTime? TimeStamp { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// The direction in which to display the notification. It defaults to auto, which just adopts the browser's language setting behavior, but you can override that behaviour by setting values of ltr and rtl (although most browsers seem to ignore these settings.)
        /// </summary>
        public string Dir { get; set; }
        /// <summary>
        /// The notification's language, as specified using a DOMString representing a BCP 47 language tag. See the Sitepoint ISO 2 letter language codes page for a simple reference.
        /// </summary>
        public string Lang { get; set; }
        /// <summary>
        /// A <see cref="string"/> representing the body text of the notification, which will be displayed below the title.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// A <see cref="string"/> representing an identifying tag for the notification.
        /// </summary>
        public string Tag { get; set; }
#region Image
        /// <summary>
        /// a <see cref="string"/> containing the URL of the image used to represent the notification when there is not enough space to display the notification itself.
        /// </summary>
        public string Badge { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an icon to be displayed in the notification.
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an image to be displayed in the notification.
        /// </summary>
        public string Image { get; set; }
#endregion
        /// <summary>
        /// An <see cref="object"/> with arbitrary data that you want associated with the notification. This can be of any data type.
        /// </summary>
        public string Data { get; set; }
        public bool? Renotify { get; set; }
        /// <summary>
        /// Indicates that a notification should remain active until the user clicks or dismisses it, rather than closing automatically. The default value is false.
        /// </summary>
        public bool? RequireInteraction { get; set; }
        public bool? Silent { get; set; }
        /// <summary>
        /// A <see cref="string"/> containing the URL of an audio file to be played when the notification fires.
        /// </summary>
        public string Sound { get; set; }
        /// <summary>
        /// noscreen: A Boolean specifying whether the notification firing should enable the device's screen or not.
        /// The default is false, which means it will enable the screen.
        /// </summary>
        public bool? NoScreen { get; set; }
        /// <summary>
        /// sticky: A Boolean specifying whether the notification should be 'sticky', i.e. not easily clearable by the user.
        /// The default is false, which means it won't be sticky.
        /// </summary>
        public bool? Sticky { get; set; }
        /// <summary>
        /// The amount of seconds until the notifciation is closed. Default is 5 seconds
        /// </summary>
        public int TimeOut { get; set; } = 5;

        public ICollection<PushMessageActions> Actions { get; set; }

        //public PushMessagesTemplate(string title, PushMessageOptions options = null)
        //{
        //    if (string.IsNullOrWhiteSpace(title))
        //        throw new ArgumentNullException($"{nameof(title)}, cannot be null or empty.");

        //    Actions = new List<PushMessageActions>();

        //    Title = title;

        //    if (options == null)
        //        return;

        //    Url = options.Url;
        //    MessageType = options.MessageType;
        //    Vibrate = options.Vibrate;
        //    TimeStamp = options.TimeStamp;
        //    Dir = options.Dir;
        //    Lang = options.Lang;
        //    Badge = options.Badge;
        //    Body = options.Body; ;
        //    Tag = options.Tag;
        //    Icon = options.Icon;
        //    Image = options.Image;
        //    Data = options.Data;
        //    Renotify = options.Renotify;
        //    RequireInteraction = options.RequireInteraction;
        //    Silent = options.Silent;
        //    Sound = options.Sound;
        //    NoScreen = options.NoScreen;
        //    Sticky = options.Sticky;
        //    TimeOut = options.TimeOut ?? TimeOut;
        //}
    }

    public class PushMessageActions
    {
        [Key] public int MessageActionId { get; set; }
        public PushMessagesTemplate Message { get; set; }
        public PushMessageAction Action { get; set; }
    }

    public class PushMessageAction
    {
        [Key] public int ActionId { get; set; }
        public string Action { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
    public class PushMessageType
    {
        [Key] public int MessageTypeId { get; set; }
        [Required] public string Name { get; set; } = "Tile";
        public string Description { get; set; }
    }
    
    public class PushMessageUrgency
    {
        public int UrgencyId { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
    }
}
