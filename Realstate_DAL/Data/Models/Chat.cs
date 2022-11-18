using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realstate_DAL;

public class Chat
{
    public Guid MessageId { get; set; }
    public string MessageContent { get; set; } = "";
    public bool IsSeen { get; set; } = false;
    public DateTime SentDate { get; set; }
    public Guid SenderId { get; set; } 
    public Guid ReciverId { get; set; }

    public UserClass? Sender { get; set; }
    public UserClass? reciver { get; set; }


}

