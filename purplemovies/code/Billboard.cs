using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

	public float updateInterval = .25f;
	Camera m_Camera;
	Vector3 cameraPosition;

	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back,
		                 m_Camera.transform.rotation * Vector3.up);
	}

	void Start ()
	{
		m_Camera = Camera.main;
		cameraPosition = m_Camera.transform.position;
//		StartCoroutine( UPDATE_ROTATION_NAME );
	}

	const string UPDATE_ROTATION_NAME = "updateRotation";
	IEnumerator updateRotation()
	{
		while(true){
			yield return new WaitForSeconds( updateInterval );

			transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back,
			                 m_Camera.transform.rotation * Vector3.up);

//			transform.LookAt( cameraPosition );
		}
	}
}
