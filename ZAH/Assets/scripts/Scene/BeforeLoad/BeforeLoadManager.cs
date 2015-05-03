using UnityEngine;
using System.Collections;
using ZuEngine.Event;
using ZuEngine;

public class BeforeLoadManager : MonoBehaviour {
	private const int WAIT_FRAME_COUNT = 5;
	private int m_frameCount = 0;
	// Use this for initialization
	void Start () {
		System.GC.Collect ();
		StartCoroutine (waitLoad ());
	}

	IEnumerator waitLoad()
	{
		while (true) {
			m_frameCount ++;
			if (m_frameCount >= WAIT_FRAME_COUNT) {
				ServiceLocator<EventManager>.Instance.SendEvent(CommonEvents.EVENT_BEFORE_LEVEL_LOAD_OK);
				yield break;
			}
			yield return new WaitForEndOfFrame ();
		}
	}

}
