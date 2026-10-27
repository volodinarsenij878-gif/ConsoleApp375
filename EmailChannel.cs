namespace Program12
{
    internal class EmailChannel
    {
        private string v;
        private bool smtpAvailable;

        public EmailChannel(string v, bool smtpAvailable)
        {
            this.v = v;
            this.smtpAvailable = smtpAvailable;
        }
    }
}