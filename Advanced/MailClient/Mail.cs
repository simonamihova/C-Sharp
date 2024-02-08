namespace MailClient
{
    public class Mail
    {

        private string sender;
        private string receiver;
        private string body;

        public Mail(string sender, string receiver, string body)
		{
			Sender = sender;
			Receiver = receiver;
			Body = body;
		}

		public string Sender
		{
			get { return sender; }
			private set { sender = value; }
		}

		public string Receiver
		{
			get { return receiver; }
			private set { receiver = value; }
		}


		public string Body
		{
			get { return body; }
			private set { body = value; }
		}

		public override string ToString() 
		{
			return $"From: {sender} / To: {receiver}\nMessage: {body}";
		}
	}
}
