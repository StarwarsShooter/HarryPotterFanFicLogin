using HarryPotterFanFicLogin.Interfaces;
using HarryPotterFanFicLogin.Interfaces.Handlers;
using HarryPotterFanFicLogin.Interfaces.Logic_Classes;
using HarryPotterFanFicLogin.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterFanFicLogin.Logic
{
    public class ForumPostLogic : IForumPostLogic
    {
        private readonly IForumPostDatabaseHandler _forumPostDatabaseHandler;

        public ForumPostLogic(IForumPostDatabaseHandler forumPostDatabaseHandler)
        {
            _forumPostDatabaseHandler = forumPostDatabaseHandler;
        }
    }
}