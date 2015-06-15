using UnityEngine;
using System.Collections;
using ZuEngine.StateManagement;
using ZuEngine;
using ZuEngine.Manager;
using ZAH.Manager;

namespace ZAH.Tasks
{
	public class AvatarMoveTask : Task  {

		public AvatarMoveTask()
		{

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
			GameObject avatar = ServiceLocator< CharacterManager >.Instance.GetAvatar ();
			Vector3 avatarPos = avatar.transform.localPosition;
			avatarPos = new Vector3 (avatarPos.x + p_deltaTime * 30, avatarPos.y, avatarPos.z);
			avatar.transform.localPosition = avatarPos;
		}

		#endregion
	}
}
