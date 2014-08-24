using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
	GlobalOverlord overlord;
	public string levelName = "level_01";

	void Awake ()
	{
		GameObject.DontDestroyOnLoad(gameObject);

		overlord = GlobalOverlord.instance;
		Debug.Log( "overlord : " + this.overlord );
		overlord.gameMaster = this;
	}
	
	void Start ()
	{
		Application.LoadLevel (levelName);
	}
}
