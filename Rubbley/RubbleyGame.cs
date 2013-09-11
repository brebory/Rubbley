using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Cocos2d;

namespace Rubbley
{
	public class RubbleyGame : Game
	{
		readonly GraphicsDeviceManager graphics;

		public RubbleyGame()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			graphics.isFullScreen = false;

			ConfigurationManager config = new ConfigurationManager();

			CCApplication application = new RubbleyApplication(this, graphics, config);
			Components.Add(application);
		}
	}
}

