using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
	GlobalOverlord overlord;
	public string levelName = "level_01";
	bool autoStartLevel = false;

	void Awake ()
	{
		GameObject.DontDestroyOnLoad(gameObject);
		overlord = GlobalOverlord.instance;
		overlord.gameMaster = this;
	}
	
	void Start ()
	{
		if( autoStartLevel )
			startGame ();
	}

	void startGame ()
	{
		Application.LoadLevel (levelName);
	}
}
