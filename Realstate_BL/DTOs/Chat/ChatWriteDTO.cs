namespace Realstate_BL;

public class ChatWriteDTO
{
    public Guid MessageId { get; set; }
    public string MessageContent { get; set; } = "";
    public bool IsSeen { get; set; } = false;
    public DateTime SentDate { get; set; }

}