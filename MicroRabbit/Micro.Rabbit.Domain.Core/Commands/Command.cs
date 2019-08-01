using Micro.Rabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Rabbit.Domain.Core.Commands
{
    public class Command:Message
    {
        public DateTime TimeStamp { get; protected set; }
        public Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
