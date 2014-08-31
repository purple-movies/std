
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;
	using Pathfinding;
	
	public class AStarAgentAdapter : PathAgentAdapterBase, IPathFindingAgent
	{
//		const int OBSTACLE_LAYER = 10;

		float stoppingDistance = .25f;

		Seeker seeker;
		Path path;
		Vector3 currentDestination = Vector3.zero;
		int currentWayPoint = 0;
		float currentSpeed;
		bool stopped = false;
		CharacterController characterController;
		CapsuleCollider collider;

		public AStarAgentAdapter( GameObject gameObject ) : base( gameObject )
		{
			speed = 150;
			collider = gameObject.GetComponent<CapsuleCollider>();
			characterController = gameObject.GetComponent<CharacterController>();
			seeker = gameObject.AddComponent<Seeker>() as Seeker;
			gameObject.AddComponent<SimpleSmoothModifier>();

			seeker.pathCallback += pathCallback;
		}

		private void pathCallback(Path path)
		{
			if ( ! path.error ) {
				this.path = path;
				currentWayPoint = 0;
			}
		}


		#region IPathFindingAgent implementation
		
		public void calculatePath ()
		{
			setDestination( currentDestination );
		}

		public void onUpdate ()
		{
			if ( stopped || path == null )
				return;

			if ( currentWayPoint >= path.vectorPath.Count ) {
				Debug.Log( "reached end of path ! " );
				return;
			}

			Vector3 dir = ( path.vectorPath[currentWayPoint] - gameObject.transform.position ).normalized;
			dir *= speed * Time.fixedDeltaTime;
			characterController.SimpleMove( dir );

			if ( Vector3.Distance( gameObject.transform.position, path.vectorPath[ currentWayPoint ]) < stoppingDistance )
			{
				currentWayPoint ++;
				return;
			}
		}

		public bool setDestination (Vector3 destination)
		{
			currentDestination = destination;
			seeker.StartPath ( gameObject.transform.position, currentDestination );
			return true;
		}
		public void stop ()
		{
			stopped = true;
////			collider.height = 5.5f;
//			gameObject.layer = OBSTACLE_LAYER;
////			gameObject.transform.localScale = new Vector3(2, 2, 2);
//			gameObject.transform.localScale = new Vector3(4, 4, 4);
//			AstarPath.active.UpdateGraphs( gameObject.collider.bounds );
////			gameObject.transform.localScale = new Vector3(1, 1, 1);
		}
		
		public float radius {
			get {
				return characterController.radius;
//				return collider.radius;
			}
			set {
//				characterController.radius = value;
//				collider.radius = value;
			}
		}
		
		public float speed {
			get { 
				return currentSpeed;
			}
			set {
				currentSpeed = value;
			}
		}
		#endregion
	}
}