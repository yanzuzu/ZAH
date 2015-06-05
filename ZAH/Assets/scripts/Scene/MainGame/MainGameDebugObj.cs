using UnityEngine;
using System.Collections;
using ZuEngine;
using ZuEngine.StateManagement;
using ZAH.State;

public class MainGameDebugObj : MonoBehaviour {
	StateManager m_stateManager;
	// Use this for initialization
	void Awake () {
		m_stateManager = new StateManager ();
		m_stateManager.ChangeState (new MainGameState(m_stateManager));  
	}
	
	// Update is called once per frame
	void Update () {
		m_stateManager.Update (Time.deltaTime);
	}
}
