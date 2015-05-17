using UnityEngine;
using System.Collections;
using ZuEngine.Manager;
using ZuEngine;

public class MainGameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject avatar = GameObject.Instantiate< GameObject >( ServiceLocator< ResourceManager >.Instance.LoadResAndCheckIn ("avatar/avatar", true) as GameObject );

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
