using UnityEngine;
using System.Collections;
using ZuEngine;
using ZuEngine.Manager;

public class StartUpUI : MonoBehaviour {

	public void OnClickStartGame()
	{
		ZuDebug.Log ("OnClickStartGame start");
		ServiceLocator< SceneLoadManager >.Instance.LoadLevel ("MainGame");
	}
}
