using System;
using Cocos2d;
using Microsoft.Xna.Framework;

namespace Rubbley
{
	public static class VectorMath
	{
		// Calculates the coordinates of a point at offset along the vector through origin and end.
		public static CCPoint PointAlongVectorWithEndpoints(float offset, CCPoint origin, CCPoint end)
		{
			return new CCPoint(origin.Position.x + offset, 
			                   ((end.Position.y - origin.Position.y) / (end.Position.x - origin.Position.y)) * offset + origin.Position.y);
		}
		// Calculates the magnitude of a vector from origin to end.
		public static float Magnitude(CCPoint origin, CCPoint end)
		{
			return Math.Sqrt(Math.Pow((end.x - origin.x), 2) + Math.Pow((end.y - origin.y), 2));
		}
	}
}

