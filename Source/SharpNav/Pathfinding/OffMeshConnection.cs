// Copyright (c) 2014-2015 Robert Rouhani <robert.rouhani@gmail.com> and other contributors (see CONTRIBUTORS file).
// Licensed under the MIT License - https://raw.github.com/Robmaister/SharpNav/master/LICENSE

using System;

using SharpNav.Geometry;

#if MONOGAME
using Vector3 = Microsoft.Xna.Framework.Vector3;
#elif OPENTK
using Vector3 = OpenTK.Vector3;
#elif SHARPDX
using Vector3 = SharpDX.Vector3;
#endif

namespace SharpNav.Pathfinding
{
	[Flags]
	public enum OffMeshConnectionFlags
	{
		None = 0x0,
		Bidirectional = 0x1
	}

	/// <summary>
	/// An offmesh connection links two polygons, which are not directly adjacent, but are accessibly through
	/// other means (jumping, climbing, etc...).
	/// </summary>
	public class OffMeshConnection
	{
		/// <summary>
		/// Gets or sets the first endpoint of the connection
		/// </summary>
		public Vector3 Pos0 { get; set; } 

		/// <summary>
		/// Gets or sets the second endpoint of the connection
		/// </summary>
		public Vector3 Pos1 { get; set; }

		/// <summary>
		/// Gets or sets the radius
		/// </summary>
		public float Radius { get; set; }

		/// <summary>
		/// Gets or sets the polygon's index
		/// </summary>
		public int Poly { get; set; }

		/// <summary>
		/// Gets or sets the polygon flag
		/// </summary>
		public OffMeshConnectionFlags Flags { get; set; }

		/// <summary>
		/// Gets or sets the endpoint's side
		/// </summary>
		public int Side { get; set; } 

		/// <summary>
		/// Gets or sets the id 
		/// </summary>
		public uint UserId { get; set; }
	}
}