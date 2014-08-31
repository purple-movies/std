
namespace purplemovies.ai
{
	using UnityEngine;
	using System.Collections;
	
	public class PathAgentAdapterBase : IPathFindingAgent
	{
		protected GameObject gameObject;

		public PathAgentAdapterBase( GameObject gameObject )
		{
			this.gameObject = gameObject;
		}

		#region IPathFindingAgent implementation

		public void calculatePath ()
		{
			throw new System.NotImplementedException ();
		}

		public void onUpdate ()
		{
			throw new System.NotImplementedException ();
		}

		public bool setDestination (Vector3 destination) {	throw new System.NotImplementedException (); }
		public void stop ()	{	throw new System.NotImplementedException (); }
		
		public float radius {
			get {
				throw new System.NotImplementedException ();
			}
			set {
				throw new System.NotImplementedException ();
			}
		}
		
		public float speed {
			get {
				throw new System.NotImplementedException ();
			}
			set {
				throw new System.NotImplementedException ();
			}
		}
		#endregion
	}
}