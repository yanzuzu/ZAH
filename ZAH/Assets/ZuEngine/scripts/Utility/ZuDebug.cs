using UnityEngine;
using System.Collections;

public class ZuDebug {

	public static void Log(string p_log)
	{
#if DEBUG
		Debug.Log (p_log);
#endif
	}

	public static void LogWarning(string p_log)
	{
#if DEBUG
		Debug.LogWarning (p_log);
#endif
	}


	public static void LogError(string p_log)
	{
#if DEBUG
		Debug.LogError (p_log);
#endif
	}
}
