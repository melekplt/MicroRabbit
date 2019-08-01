using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Rabbit.Domain.Core.Events
{
    public class Event
    {
        public DateTime TimeStamp { get; protected set; }
        public Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
