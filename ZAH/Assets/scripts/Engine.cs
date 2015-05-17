using UnityEngine;
using System.Collections;
using ZuEngine.StateManagement;
using ZAH.State;

namespace ZAH
{
	public class Engine : MonoBehaviour {
		private StateManager m_stateManager;

		// Use this for initialization
		void Start () {
			m_stateManager = new StateManager ();
			m_stateManager.ChangeState (new TitleState (m_stateManager));  
		}
		
		// Update is called once per frame
		void Update () {
			m_stateManager.Update (Time.deltaTime);
		}
	}
}
