using UnityEngine;
using System.Collections;
using ZuEngine;
using ZAH.Manager;

[RequireComponent( typeof( Camera ))]
public class ZahCamera : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		ServiceLocator< CameraManager >.Instance.Register (this.GetComponent< Camera > ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
