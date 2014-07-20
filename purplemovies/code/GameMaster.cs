using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
	GlobalOverlord overlord;

	void Awake ()
	{
		GameObject.DontDestroyOnLoad(gameObject);

		overlord = GlobalOverlord.instance;
		Debug.Log( "overlord : " + this.overlord );
		overlord.gameMaster = this;
	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log( "Start !!" );
		Application.LoadLevel("level_01");
	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
