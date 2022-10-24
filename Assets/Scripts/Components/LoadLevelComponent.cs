using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChildPaint.Components
{
	public class LoadLevelComponent : MonoBehaviour
	{
		public void LoadScene(int number = 0) 
		{
			SceneManager.LoadScene(number);
		}
	}
}

