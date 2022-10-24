using UnityEngine;

namespace ChildPaint.Components
{
	public class ExitAppComponent : MonoBehaviour
	{
		public void Exit() 
		{
			Application.Quit();
		}		
	}
}

