using UnityEngine;
using System.Collections;
using ZuEngine;
using ZuEngine.Event;
using ZuEngine.Manager;
 
public class StartupManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		ServiceLocator< SceneLoadManager >.Instance.BeforeLoadLevelName = "BeforeLoadLevelScene";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
