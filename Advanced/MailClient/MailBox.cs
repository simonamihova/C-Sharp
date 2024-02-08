using System.Text;

namespace MailClient
{
    public class MailBox
    {

		public MailBox(int capacity)
		{
			Capacity= capacity;
			Inbox = new List<Mail>();
			Archive= new List<Mail>();
		}
		private int capacity;

		public int Capacity
		{
			get { return capacity; }
			private set { capacity = value; }
		}

		private List<Mail>  inbox;

		public List<Mail> Inbox
		{
			get { return  inbox; }
			private set {  inbox = value; }
		}

		private List<Mail> archive;

		public List<Mail> Archive
		{
			get { return archive; }
			private set { archive = value; }
		}

        public void IncomingMail(Mail mail)
		{
			if(inbox.Count < Capacity)
			{
				inbox.Add(mail);
			}			
		}

		public bool DeleteMail(string sender)
		{

			Mail mail = Inbox.FirstOrDefault(m => m.Sender == sender);

			if(mail != null)
			{
                Inbox.Remove(mail);
				return true;
            }

            return false;
		}

		public int ArchiveInboxMessages()
		{
			int count = 0;
			foreach(var mail in Inbox)
			{
				Archive.Add(mail);
				count++;
			}

            return count;
		}


		public string GetLongestMessage()
		{
			Mail longestMail = inbox[0];

			foreach (var mail in inbox)
			{
				if (mail.Body.Length > longestMail.Body.Length)
				{
					longestMail = mail;
				}
			}

			return longestMail.ToString();
		}

		public string InboxView()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Inbox:");
			foreach(Mail mail in inbox)
			{
				sb.AppendLine(mail.ToString());
			}

			return sb.ToString().Trim();
		}

    }
}
