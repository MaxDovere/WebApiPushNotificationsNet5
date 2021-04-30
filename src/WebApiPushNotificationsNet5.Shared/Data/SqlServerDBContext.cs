using Microsoft.EntityFrameworkCore;
using WebApiPushNotificationsNet5.Shared.Models;

namespace WebApiPushNotificationsNet5.Shared.Data
{
    public class SqlServerDBContext : DbContext
    {
        /// <summary>
        /// Model rappresentation table: PushNotificationUser [to save all notification sending]
        /// </summary>
        public DbSet<PushNotificationUser> PushNotificationUser { get; set; }
        /// <summary>
        /// Model rappresentation table: PushSubscriptionUser [to save all subscription subscribed]
        /// </summary>
        public DbSet<PushSubscriptionUser> PushSubscriptionUser { get; set; }
        /// <summary>
        /// Model rappresentation table: PushSubscriptionTopic [to save Many Topic with One subscription]
        /// </summary>
        public DbSet<PushSubscriptionTopic> PushSubscriptionTopic { get; set; }
        /// <summary>
        /// Model rappresentation table: PushTopics [to save all Topics existed]
        /// </summary>
        public DbSet<PushTopics> PushTopics { get; set; }
        /// <summary>
        /// Model rappresentation table: PushMessageType [to save all message type ]
        /// </summary>
        public DbSet<PushMessageType> PushMessageType { get; set; }
        /// <summary>
        /// Model rappresentation table: PushMessageActions [to save all message actions desiderate]
        /// </summary>
        public DbSet<PushMessageActions> PushMessageActions { get; set; }
        /// <summary>
        /// Model rappresentation table: PushMessageAction [to save all single action One message]
        /// </summary>
        public DbSet<PushMessageAction> PushMessageAction { get; set; }
        /// <summary>
        /// Model rappresentation table: PushMessagesTemplate [to save all message template]
        /// </summary>
        public DbSet<PushMessagesTemplate> PushMessagesTemplate { get; set; }
        /// <summary>
        /// Model rappresentation table: PushMessageUrgency [to save all message urgency time ]
        /// </summary>
        public DbSet<PushMessageUrgency> PushMessageUrgency { get; set; }

        public SqlServerDBContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PushNotificationUser>()
                .HasKey(p => p.NotificationId);
            modelBuilder.Entity<PushTopics>()
                .HasKey(p => p.TopicId);
            modelBuilder.Entity<PushSubscriptionTopic>()
                .HasKey(p => p.SubscriptionTopicId);
            modelBuilder.Entity<PushSubscriptionUser>()
                .HasKey(p => p.SubscriptionId);
            modelBuilder.Entity<PushMessagesTemplate>()
                .HasKey(p => p.MessageId);
            modelBuilder.Entity<PushMessageActions>()
                .HasKey(p => p.MessageActionId);
            modelBuilder.Entity<PushMessageAction>()
                .HasKey(p => p.ActionId);
            modelBuilder.Entity<PushMessageType>()
                .HasKey(p => p.MessageTypeId);
            modelBuilder.Entity<PushMessageUrgency>()
                .HasKey(p => p.UrgencyId);

            modelBuilder.Entity<PushMessagesTemplate>()
                .HasMany(o => o.Actions)
                .WithOne(o => o.Message);

            modelBuilder.Entity<PushMessageActions>()
                .HasOne(o => o.Message)
                .WithMany(o => o.Actions);

            modelBuilder.Entity<PushSubscriptionUser>()
                .HasMany(o => o.Topics)
                .WithOne(o => o.Subscription);

            modelBuilder.Entity<PushSubscriptionTopic>()
                .HasOne(o => o.Subscription)
                .WithMany(o => o.Topics);


            //EntityTypeBuilder<PushSubscriptionTopic> webpushTopicEntityTypeBuilder = modelBuilder.Entity<PushSubscriptionTopic>();
            //webpushTopicEntityTypeBuilder.HasKey(p => p.TopicId);

            //EntityTypeBuilder<PushSubscriptionUser> webpushSubscriptionEntityTypeBuilder = modelBuilder.Entity<PushSubscriptionUser>();
            //webpushSubscriptionEntityTypeBuilder.HasKey(p => p.SubscriptionId);
            ////webpushSubscriptionEntityTypeBuilder.Ignore(p => p.Keys);

            //EntityTypeBuilder<PushNotificationUser> pushNotificationUserEntityTypeBuilder = modelBuilder.Entity<PushNotificationUser>();
            //pushNotificationUserEntityTypeBuilder.HasKey(e => e.NotificationId);
            ////pushNotificationUserEntityTypeBuilder.Ignore(p => p.UserId);

            //EntityTypeBuilder<PushNotificationMessagesTemplate> webpushMessageEntityTypeBuilder = modelBuilder.Entity<PushNotificationMessagesTemplate>();
            //webpushMessageEntityTypeBuilder.HasKey(p => p.MessageId);

            //EntityTypeBuilder<PushNotificationMessageActions> webpushMessageActionsEntityTypeBuilder = modelBuilder.Entity<PushNotificationMessageActions>();
            //webpushMessageActionsEntityTypeBuilder.HasKey(p => p.MessageActionId);

            //EntityTypeBuilder<PushNotificationMessageType> webpushMessageTypeEntityTypeBuilder = modelBuilder.Entity<PushNotificationMessageType>();
            //webpushMessageTypeEntityTypeBuilder.HasKey(p => p.MessageTypeId);

            //EntityTypeBuilder<PushNotificationMessageUrgency> webpushMessageUrgencyEntityTypeBuilder = modelBuilder.Entity<PushNotificationMessageUrgency>();
            //webpushMessageUrgencyEntityTypeBuilder.HasKey(p => p.UrgencyId);

            //modelBuilder.Entity<PushNotificationMessagesTemplate>()
            //    .HasMany(o => o.MessageActions)
            //    .WithOne(o => o.Message);

            //modelBuilder.Entity<PushNotificationMessageActions>()
            //    .HasOne(o => o.Message)
            //    .WithMany(o => o.MessageActions);

        }
    }
}
