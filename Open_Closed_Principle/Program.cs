using Open_Closed_Principle;

NotificationService notificationService = new NotificationService();
notificationService.AddNotification(new EmailNotification());
notificationService.AddNotification(new SmsNotification());
notificationService.NotifyAll("this is test message!");