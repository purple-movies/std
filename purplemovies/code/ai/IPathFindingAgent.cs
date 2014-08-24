
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;

	public interface IPathFindingAgent
	{
		bool setDestination( Vector3 destination );
		void stop();

		float radius { get; set; }
		float speed { get; set; }
	}
}