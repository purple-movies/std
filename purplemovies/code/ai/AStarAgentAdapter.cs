
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;
	
	public class AStarAgentAdapter : PathAgentAdapterBase, IPathFindingAgent
	{
		public AStarAgentAdapter( GameObject gameObject ) : base( gameObject ) {}
	}
}