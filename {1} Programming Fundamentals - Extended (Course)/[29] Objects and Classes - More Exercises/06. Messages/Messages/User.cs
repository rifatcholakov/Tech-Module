using System.Collections.Generic;

namespace Messages
{
    public class User
    {
        public string username { get; set; }

        public List<Message> receivedMessages { get; set; }
    }
}
