using UnityEngine;
using KBEngine;
using System.Collections;
namespace KBEngine
{
public class Dbg {
	public static void DEBUG_MSG(object s)
	{
		Debug.Log(s);
	}
	
	public static void WARNING_MSG(object s)
	{
		Debug.LogWarning(s);
	}
	
	public static void ERROR_MSG(object s)
	{
		Debug.LogError(s);
	}
}
}
