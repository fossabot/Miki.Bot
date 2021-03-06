﻿using System;
using System.Threading.Tasks;

namespace Miki.Accounts.Achievements.Objects
{
	internal class CommandAchievement : BaseAchievement
	{
		public Func<CommandPacket, Task<bool>> CheckCommand;

		public override async Task<bool> CheckAsync(BasePacket packet)
		{
			return await CheckCommand(packet as CommandPacket);
		}
	}
}