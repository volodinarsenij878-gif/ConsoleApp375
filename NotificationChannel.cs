using System;

namespace Program12
{
    internal class NotificationChannel
    {
        public static implicit operator NotificationChannel(EmailChannel v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator NotificationChannel(TelegramChannel v)
        {
            throw new NotImplementedException();
        }
    }
}