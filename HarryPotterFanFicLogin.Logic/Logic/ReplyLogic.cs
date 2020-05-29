using HarryPotterFanFicLogin.Interfaces;
using HarryPotterFanFicLogin.Interfaces.Handlers;
using HarryPotterFanFicLogin.Interfaces.Logic_Classes;

namespace HarryPotterFanFicLogin.Logic
{
    public class ReplyLogic : IReplyLogic
    {
        private readonly IReplyDatabaseHandler _replyDataBaseHandler;

        public ReplyLogic(IReplyDatabaseHandler replyDataBaseHandler)
        {
            _replyDataBaseHandler = replyDataBaseHandler;
        }

        private IReplyDatabaseHandler ReplyDataBaseHandler { get; }
    }
}