
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;

	public class NMAgentAdapter : PathAgentAdapterBase, IPathFindingAgent
	{
		NavMeshAgent navMeshAgent;

		public NMAgentAdapter( GameObject gameObject ) : base( gameObject )
		{
			navMeshAgent = gameObject.AddComponent<NavMeshAgent>() as NavMeshAgent;
			navMeshAgent.radius = .6f;
			navMeshAgent.speed = 2;
			navMeshAgent.acceleration = 8;
			navMeshAgent.angularSpeed = 120;
			navMeshAgent.stoppingDistance = 0;
			navMeshAgent.autoTraverseOffMeshLink = true;
			navMeshAgent.autoBraking = true;
			navMeshAgent.autoRepath = true;
			navMeshAgent.height = 2;
			navMeshAgent.baseOffset = 0;
			navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
			navMeshAgent.avoidancePriority = 99;
			navMeshAgent.walkableMask = -1;

//			navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
//			Debug.Log( "walk layer : " + navMeshAgent.walkableMask );
		}
		#region IPathFindingAgent implementation
		
		public void calculatePath ()
		{
		}

		public void onUpdate ()
		{
		}

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