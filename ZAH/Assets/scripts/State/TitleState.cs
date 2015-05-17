using UnityEngine;
using System.Collections;
using ZuEngine.StateManagement;
using ZAH.Event;
using ZuEngine.Event;
using ZuEngine;
using ZuEngine.Manager;

namespace ZAH.State
{
	public class TitleState : GameState {

		public TitleState( StateManager stateManager ): base(stateManager)
		{
			ListenForEvent (EventIDs.ON_PLAY_BUTTON_PRESSED, OnPlayBtnPressed );
			ListenForEvent (CommonEvents.EVENT_LOAD_LEVEL_OK, OnLoadLevelOK);
		}

		private EventResult OnPlayBtnPressed( string eventName , object param )
		{
			ServiceLocator< SceneLoadManager >.Instance.LoadLevel ("MainGame");
			return null;
		}

	#region implement GameState
		public override void Init()
		{

		}
	#endregion

		EventResult OnLoadLevelOK( string eventName , object param )
		{
			int levelIdx =  (int)param;
			if( levelIdx == 2 )
			{
				StateManager.ChangeState (new MainGameState (StateManager));
			}
			return null;
		}

	}
}
