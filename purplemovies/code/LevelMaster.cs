using UnityEngine;
using System.Collections;

public class LevelMaster : MonoBehaviour
{
	protected GameMaster gameMaster;

	protected void Awake()
	{
		gameMaster = GlobalOverlord.instance.gameMaster;
		Debug.Log( "my master :" + gameMaster );
	}
}
