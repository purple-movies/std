using UnityEngine;
using System.Collections;

public class LevelMaster : MonoBehaviour
{
	private GameMaster gameMaster;

	void Awake()
	{
		gameMaster = GlobalOverlord.instance.gameMaster;
		Debug.Log( "my master :" + gameMaster );
	}

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
