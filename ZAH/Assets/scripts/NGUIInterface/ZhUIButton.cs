using UnityEngine;
using System.Collections;

public class ZhUIButton : UIButton {
	/// <summary>
	/// Indicates the ui type of the button by sam
	/// </summary>
	public enum BTN_UI_TYPE
	{
		NONE,
		OK,
		CANCEL,
	}; 

	[SerializeField]
	private  BTN_UI_TYPE m_btnUIType = BTN_UI_TYPE.OK;

	protected override void OnInit()
	{
		base.OnInit();
	}
}
