using System;
using System.Linq;
using WebApiPushNotificationsNet5.Shared.Models;

namespace WebApiPushNotificationsNet5.Shared.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SqlServerDBContext context)
        {
            // Look for any students.
            if (context.PushTopics.Any())
            {
                //If database is over return no data.
                return;   // DB has been seeded
            }
            var _pushTopics = new PushTopics[]
            {
                new PushTopics {TopicFilters = "Lead",Actived= true, TimeAfterToSend= new TimeSpan(00,00,30) },
                new PushTopics {TopicFilters = "Activity",Actived= true, TimeAfterToSend= new TimeSpan(00,00,30) },
                new PushTopics {TopicFilters = "ActionCRM",Actived= true, TimeAfterToSend= new TimeSpan(00,00,30) },
                new PushTopics {TopicFilters = "Other",Actived= true, TimeAfterToSend= new TimeSpan(00,00,30) },
            };
            foreach (PushTopics e in _pushTopics)
            {
                context.PushTopics.Add(e);
            }
            context.SaveChanges();

            var _pushMessageTypes = new PushMessageType[]
            { 
                new PushMessageType {Name = "Tile", Description="Tile Message"},
                new PushMessageType {Name = "Toast", Description = "Toast Message" },
                new PushMessageType {Name = "Push", Description = "Push Message" },
                new PushMessageType {Name = "Normal", Description = "Normal Message" },
                new PushMessageType {Name = "Lead", Description = "Lead Message" }
            };
            foreach (PushMessageType e in _pushMessageTypes)
            {
                context.PushMessageType.Add(e);
            }
            context.SaveChanges();

            var _pushMessageUrgencys = new PushMessageUrgency[]
            {
                new PushMessageUrgency{Name="Very Low",Description="Battery full max power"},
                new PushMessageUrgency{Name="Low",Description="Battery semi full"},
                new PushMessageUrgency{Name="Normal",Description="Battery normal"},
                new PushMessageUrgency{Name="Medium",Description="Battery medium no power full"},
                new PushMessageUrgency{Name="High",Description="Battery low no power"}
            };
            foreach (PushMessageUrgency e in _pushMessageUrgencys)
            {
                context.PushMessageUrgency.Add(e);
            }
            context.SaveChanges();

            var _pushSubscriptionUsers = new PushSubscriptionUser[]
            {
                new PushSubscriptionUser{UserId="Max", Endpoint="http://fcm.google.com/sjfasfjfjaf", P256DH="alfalsfasfklsflafll", Auth="falflafafaklflasfafla", CreatedTime=DateTime.UtcNow},
                new PushSubscriptionUser{UserId="4022", Endpoint="http://fcm.google.com/sjfasfjfjaf", P256DH="alfalsfasfklsflafll", Auth="falflafafaklflasfafla", CreatedTime=DateTime.UtcNow},
                new PushSubscriptionUser{UserId="4023", Endpoint="http://fcm.google.com/sjfasfjfjaf", P256DH="alfalsfasfklsflafll", Auth="falflafafaklflasfafla", CreatedTime=DateTime.UtcNow},
                new PushSubscriptionUser{UserId="4024", Endpoint="http://fcm.google.com/sjfasfjfjaf", P256DH="alfalsfasfklsflafll", Auth="falflafafaklflasfafla", CreatedTime=DateTime.UtcNow}
            };
            foreach (PushSubscriptionUser c in _pushSubscriptionUsers)
            {
                context.PushSubscriptionUser.Add(c);
            }
            context.SaveChanges();

            var _pushSubscriptionTopics = new PushSubscriptionTopic[]
            {
                new PushSubscriptionTopic{Topic=_pushTopics[0], Subscription=_pushSubscriptionUsers[0] },
                new PushSubscriptionTopic{Topic=_pushTopics[0], Subscription= _pushSubscriptionUsers[1]},
                new PushSubscriptionTopic{Topic=_pushTopics[1], Subscription= _pushSubscriptionUsers[1]},
                new PushSubscriptionTopic{Topic=_pushTopics[2], Subscription= _pushSubscriptionUsers[0]}
            };
            foreach (PushSubscriptionTopic s in _pushSubscriptionTopics)
            {
                context.PushSubscriptionTopic.Add(s);
            }
            context.SaveChanges();

            var _pushUsers = new PushNotificationUser[]
            {
                new PushNotificationUser{UserId="4022",SubscriptionId=2,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
                new PushNotificationUser{UserId="4022",SubscriptionId=2,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
                new PushNotificationUser{UserId="Max",SubscriptionId=1,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
                new PushNotificationUser{UserId="Max",SubscriptionId=1,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
                new PushNotificationUser{UserId="4023",SubscriptionId=3,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
                new PushNotificationUser{UserId="4024",SubscriptionId=4,NotificationMessage="{message: ''}", CreatedTime=DateTime.Now},
            };
            foreach (PushNotificationUser e in _pushUsers)
            {
                context.PushNotificationUser.Add(e);
            }
            context.SaveChanges();
        }
    }
}
