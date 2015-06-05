using UnityEngine;
using System.Collections;
using ZuEngine.StateManagement;
using ZuEngine;
using ZuEngine.Manager;
using ZAH.Manager;
using ZuEngine.Event;
using ZAH.Tasks;

namespace ZAH.State
{
	public class MainGameState : GameState  {

		private static long State_Play;

		public MainGameState( StateManager stateManager ): base(stateManager)
		{
			ZuDebug.Log ("############## MainGameState init ##############");
			ServiceLocator< CharacterManager >.Instance.CreateAvatar();

			State_Play = TaskManager.CreateState();

			TaskManager.AddTask (new AvatarMoveTask () , State_Play );
			TaskManager.AddTask (new PlayerCameraMoveTask () , State_Play );

			TaskManager.ChangeState (State_Play);
		}

		#region implement GameState
		public override void Init()
		{
		}
		#endregion

	}
}
