using UnityEngine;
using System.Collections;
using ZuEngine;
using ZuEngine.Manager;

namespace ZAH.Manager
{
	public class CharacterManager : MonoBehaviour {

		private const string AVATAR_RES_PATH = "avatar/avatar";
		private GameObject m_avatar;
		public GameObject GetAvatar()
		{
			return m_avatar;
		}
		public void CreateAvatar()
		{
			m_avatar = ServiceLocator< ResourceManager >.Instance.LoadRes (AVATAR_RES_PATH, true);
		}
	}
}
