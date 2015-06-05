using UnityEngine;
using System.Collections;
using ZuEngine.StateManagement;
using ZuEngine;
using ZAH.Manager;

namespace ZAH.Tasks
{
	public class PlayerCameraMoveTask : Task {

		CharacterManager m_characMgr;
		CameraManager m_cameraMgr;

		public PlayerCameraMoveTask()
		{
			m_characMgr = ServiceLocator< CharacterManager >.Instance;
			m_cameraMgr = ServiceLocator< CameraManager >.Instance;
		}

		#region implement abtract member of Task
		
		public override void Pause()
		{
			
		}
		
		public override void Resume()
		{
			
		}
		
		public override void Show(bool p_show)
		{
			
		}
		
		public override void Update(float p_deltaTime)
		{
			// target to the player
			Camera playerCamera = m_cameraMgr.GetCamera (CameraManager.PLAYER_CAMERA_NAME);
			Vector3 playerCameraPos =  playerCamera.transform.localPosition;
			Vector3 playerPos = m_characMgr.GetAvatar ().transform.localPosition;

			Vector3 playerCameralocalTargetPos = new Vector3 (playerPos.x, playerCameraPos.y, playerCameraPos.z);
			playerCamera.transform.localPosition = Vector3.Lerp (playerCameraPos, playerCameralocalTargetPos  , p_deltaTime );
		}
		
		#endregion
	}
}
