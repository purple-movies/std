using UnityEngine;
using System.Collections;

public class GlobalOverlord
{
	public GameMaster gameMaster;

	public static GlobalOverlord instance{
		get { return _instance; }
	}
	protected GlobalOverlord(){}
	protected static readonly GlobalOverlord _instance = new GlobalOverlord();
}