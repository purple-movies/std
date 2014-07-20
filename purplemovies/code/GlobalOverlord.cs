using UnityEngine;
using System.Collections;

public sealed class GlobalOverlord
{
	public GameMaster gameMaster;

	public static GlobalOverlord instance{
		get { return _instance; }
	}
	private GlobalOverlord(){}
	private static readonly GlobalOverlord _instance = new GlobalOverlord();
}