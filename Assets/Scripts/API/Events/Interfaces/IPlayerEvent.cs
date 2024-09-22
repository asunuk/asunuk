﻿using API.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Events.Interfaces
{
	public interface IPlayerEvent : IEvent
	{
		PlayerMovableRole player { get; }
	}
}
