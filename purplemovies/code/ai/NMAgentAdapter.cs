
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;

	public class NMAgentAdapter : PathAgentAdapterBase, IPathFindingAgent
	{
		NavMeshAgent navMeshAgent;

		public NMAgentAdapter( GameObject gameObject ) : base( gameObject )
		{
			navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		}
		#region IPathFindingAgent implementation
		
		public bool setDestination (Vector3 destination)
		{
			return navMeshAgent.SetDestination( destination );
		}

		public void stop ()
		{
			navMeshAgent.avoidancePriority = 0;
			navMeshAgent.Stop ();
		}

		public float radius {
			get { return navMeshAgent.radius; }
			set
			{
				navMeshAgent.radius = value;
			}
		}

		public float speed {
			get { return navMeshAgent.speed; }
			set
			{
				navMeshAgent.speed = value;
			}
		}
		#endregion
	}
}