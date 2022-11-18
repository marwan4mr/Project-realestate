
namespace Realstate_BL;
public class ChatReadDTO
    {

    public Guid MessageId { get; set; }
    public string MessageContent { get; set; } = "";
    public bool IsSeen { get; set; } = false;
    public DateTime SentDate { get; set; }
    public UserClass SenderId { get; set; } = new UserClass();
    public UserClass ReciverId { get; set; } = new UserClass();

}
