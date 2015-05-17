﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ZuEngine.Manager
{
	public class ResourceManager : MonoBehaviour 
	{
		private Dictionary< string , Object > m_resMap = new Dictionary<string, Object>();

		public Object LoadResAndCheckIn( string path , bool forceLoad = false )
		{
			if( m_resMap.ContainsKey( path ) )
			{
				return m_resMap[ path ];
			}

			if( forceLoad )
			{
				// TODO: should create a assetBundle res flow
				Object loadObj =  Resources.Load( path );
				if( null == loadObj )
				{
					ZuDebug.LogError(string.Format("this res = {0} can't find in res" , path ) );
					return null;
				}
				m_resMap[ path ] = loadObj;
				return m_resMap[ path ];
			}else
			{
				ZuDebug.LogError(string.Format( "no this res  = {0} is loaded before" , path ) );
				return null;
			}		           
		}

		public void CheckOutRes( string path )
		{
			if( !m_resMap.ContainsKey( path ) )
			{
				ZuDebug.LogError(string.Format("this res = {0} isn't loaded before " , path ));
				return;
			}
			m_resMap.Remove (path);
		}
					
	}
}
