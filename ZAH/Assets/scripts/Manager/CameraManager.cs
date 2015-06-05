using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ZAH.Manager
{
	public class CameraManager : MonoBehaviour {
		public const string PLAYER_CAMERA_NAME = "PlayerCamera";

		private Dictionary< string , Camera > m_cameraObjMap = new Dictionary<string, Camera >();

		public void Register( Camera p_obj )
		{
			if (m_cameraObjMap.ContainsKey (p_obj.name)) 
			{
				ZuDebug.LogWarning(string.Format("have the repeat camera register!!"));
				return;
			}
			m_cameraObjMap [p_obj.name] = p_obj;
		}

		public Camera GetCamera( string p_name )
		{
			if( !m_cameraObjMap.ContainsKey( p_name ) )
			{
				ZuDebug.LogWarning( string.Format("no any camera obj name = {0} can get!" , p_name ) );
				return null;
			}
			return m_cameraObjMap[p_name];
		}

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
