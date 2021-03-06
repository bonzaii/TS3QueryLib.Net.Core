﻿using TS3QueryLib.Net.Core.Common.Commands;
using TS3QueryLib.Net.Core.Server.Responses;

namespace TS3QueryLib.Net.Core.Server.Commands
{
    public class InstanceInfoCommand : ExecutableCommand<InstanceInfoCommandResponse>
    {
        public InstanceInfoCommand() : base("InstanceInfo")
        {
        }
    }
}