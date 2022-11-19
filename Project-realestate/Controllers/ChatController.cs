using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Realstate_BL;
using Realstate_DAL;

namespace Project_realestate.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatManager _chatManager;

        public ChatController(IChatManager chatManager)
        {
            _chatManager = chatManager;
        }   

        [HttpGet]
        [Route("{ViewLastChats}")]
        public ActionResult<List <ChatReadDTO>> ViewLastChats(Guid id)
        {
            var chatDTO = _chatManager.GetLastChat(id);
            if(chatDTO == null) return NotFound();
            return chatDTO;
        }

        [HttpGet]
        [Route("{GetChatDetails}")]
        public ActionResult <List<ChatReadDTO>> GetChatDetails(Guid senderId, Guid reciverId)
        {
           return _chatManager.GetChatBySenderAndReciver( senderId,  reciverId);
        }

        [HttpPost]
        public  ActionResult SendMessage(ChatWriteDTO mychat)
        {
            _chatManager.AddChat(mychat);
            return Ok();
        }
    }
}
