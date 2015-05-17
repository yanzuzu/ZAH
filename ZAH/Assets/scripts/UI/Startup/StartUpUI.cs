using UnityEngine;
using System.Collections;
using ZuEngine;
using ZuEngine.Manager;
using ZuEngine.Event;
using ZAH.Event;

public class StartUpUI : MonoBehaviour {

	public void OnClickStartGame()
	{
		ZuDebug.Log ("OnClickStartGame start");
		ServiceLocator<  EventManager >.Instance.SendEvent (EventIDs.ON_PLAY_BUTTON_PRESSED);
	}
}
