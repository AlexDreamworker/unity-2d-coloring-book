using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Navigation
{
	public class FirstEnterGet : MonoBehaviour
	{
		[SerializeField] private UnityEvent _onFirst;
		[SerializeField] private UnityEvent _notFirst;

		private readonly string _prefsFirstEnterKey = "is-first";

		public void EventCall()
		{
			if (PlayerPrefs.GetInt(_prefsFirstEnterKey) != 1)
				_onFirst?.Invoke();
			else 
				_notFirst?.Invoke();
		}
	}
}

