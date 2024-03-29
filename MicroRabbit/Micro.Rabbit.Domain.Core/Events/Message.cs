﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Rabbit.Domain.Core.Events
{
    public class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
