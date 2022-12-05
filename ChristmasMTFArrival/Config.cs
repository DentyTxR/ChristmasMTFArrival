using Exiled.API.Interfaces;
using Exiled.API.Extensions;
using Exiled.API.Enums;
using Exiled.API.Features;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features.Items;
using Exiled.Events.Handlers;
using Item = Exiled.API.Features.Items.Item;

namespace ChristmasMTFArrival
{
	public class Config : IConfig
	{
		[Description("Whether or not the plugin is enabled.")]
		public bool IsEnabled { get; set; } = true;

		[Description("Should debug logs be enabled?")]
		public bool EnableDebug { get; set; } = false;
	}
}
