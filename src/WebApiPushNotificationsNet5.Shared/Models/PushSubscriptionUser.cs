
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiPushNotificationsNet5.Shared.Models
{
    public class PushSubscriptionUser
    {
        [Key] public int SubscriptionId { get; set; }
        [Required] public string Endpoint { get; set; }
        public string UserId { get; set; }
        [Required] public string P256DH { get; set; }
        [Required] public string Auth { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime DateEndTime { get; set; }

        public ICollection<PushSubscriptionTopic> Topics { get; set; }

        public PushSubscriptionUser()
        {
            Topics = new List<PushSubscriptionTopic>();
        }
    }
    public class PushSubscriptionTopic
    {
        [Key] public int SubscriptionTopicId { get; set; }
        public PushSubscriptionUser Subscription { get; set; }
        public PushTopics Topic { get; set; }
        public bool Actived { get; set; }
    }

    //public class PushSubscriptionTopic
    //{
    //    [Required] public int SubscriptionId { get; set; }
    //    [Required] public int TopicId { get; set; }
    //    public bool Actived { get; set; } = false;
    //}

    public class PushTopics
    {
        [Key] public int TopicId { get; set; }
        [Required] public string TopicFilters { get; set; }
        [Required] public bool Actived { get; set; } = false;
        public TimeSpan TimeAfterToSend { get; set; }

    }


}
