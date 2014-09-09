using UnityEngine;
using System.Collections;

public class LevelMaster : MonoBehaviour
{
	public string currentLevelName = "";
	public string nextLevelName = "";
	
	protected GameMaster gameMaster;

	protected void Awake()
	{
		gameMaster = GlobalOverlord.instance.gameMaster;
	}
	
	public void startNextLevel()
	{
		Application.LoadLevel( nextLevelName );
	}
	
	public void restartLevel()
	{
		Application.LoadLevel( currentLevelName );
	}
}