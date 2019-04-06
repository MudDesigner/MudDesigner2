﻿using MudDesigner.Engine.Components.Actors;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MudDesigner.Engine
{
    public interface IServerConnection : IDisposable
    {
        IPEndPoint EndPoint { get; }

        Task SendTo(IPlayer player, string message);
    }
}