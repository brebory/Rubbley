using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Cocos2d;
using CocosDenshion;

namespace Rubbley
{
	public class RubbleyApplication : CCApplication
	{
		public RubbleyApplication(Game game, GraphicsDeviceManager graphics, ConfigurationManager config)
			: base(game, graphics)
		{
			s_pSharedApplication = this;

			CCDrawManager.InitializeDisplay(game, graphics, DisplayOrientation.Portrait);

			graphics.PreferMultiSampling = false;
		}

		public override bool ApplicationDidFinishLaunching()
		{

			// Initialize CCDirector with OpenGL view
			CCDirector director = CCDirector.SharedDirector;
			director.setOpenGLView();

			// Set up 2D projection for view matrix
			director.Projection = CCDirectorProjection.Projection2D;

			// Turn on display FPS if debug mode
			director.DisplayStats = config.getValueWithDefault("Debug", false);

			// Set FPS to 60fps
			director.AnimationInterval = 1.0 / 60;

			// Get scene from GameStartLayer

			CCScene scene = GameStartLayer.Scene;

			director.RunWithScene(scene);

			// Return true since the app did successfully finish launching.
			return true;
		}

		public override void ApplicationDidEnterBackground()
		{
			// Stop all currently running animations.
			CCDirector.SharedDirector.Pause();

			// Stop all currently playing music.
			CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = true;
		}

		public override void ApplicationWillEnterForeground()
		{
			// Resume all animation.
			CCDirector.SharedDirector.Resume();

			// Resume background music.
			CCSimpleAudioEngine.SharedEngine.PauseBackgroundMusic = false;
		}
	}
}

