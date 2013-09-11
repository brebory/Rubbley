using System;
using Cocos2d;
using XNA = Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Rubbley
{
	public class GameLayer : CCLayerColor
	{
		CCSprite player;
		const float ASTEROID_SPEED = 500.0f;
		float dt = 0.0f;
		List<CCSprite> visibleAsteroids;
		List<CCSprite> hitAsteroids;

		public GameLayer()
		{
			TouchEnabled = true;
			Color = new CCColor3B(XNA.Color.White);
			Opacity = 255;

			visibleAsteroids = new List<CCSprite>();
			hitAsteroids = new List<CCSprite>();

			player = new CCSprite("Player");
			player.Position = CCDirector.SharedDirector.WinSize.Center;
			addChild(player);
		}

		CCSprite AddAsteroid()
		{
			var asteroid = new CCSprite("Asteroid");

			// Generate random x value for Asteroid to spawn at.
			double random = new Random().NextDouble();
			double randomX = (random > 0)
				? random * CCDirector.SharedDirector.WinSize.Width - asteroid.ContentSize.Width / 2
				: asteroid.ContentSize.Width / 2;

			// Place asteroid at random x position and y position just outside of screen bounds.
			asteroid.Position = new CCPoint((float)randomX, CCDirector.SharedDirector.WinSize.Height + asteroid.ContentSize.Height / 2);

			AddChild(asteroid);

			// Animate the asteroid sprite

			var moveAsteroid = new CCMoveTo(5.0f, 
			                                VectorMath.PointAlongVectorWithEndpoints(VectorMath.Magnitude(asteroid.Position, player.Position),
			                                                                         asteroid.Position,
			                                                                         player.Position));

			return asteroid;
		}

		public override void TouchesBegan(List<CCTouch> touches)
		{
			base.TouchesBegan(touches);

			var location = touches[0].Location;
		}
	}
}

