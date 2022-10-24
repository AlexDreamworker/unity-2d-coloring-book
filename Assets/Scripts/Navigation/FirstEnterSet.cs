using UnityEngine;

namespace ChildPaint.Navigation
{
	public class FirstEnterSet : MonoBehaviour
	{
		private readonly string _prefsFirstEnterKey = "is-first";

		void Start()
		{
			PlayerPrefs.SetInt(_prefsFirstEnterKey, 1);
			PlayerPrefs.Save();
		}
	}
}

