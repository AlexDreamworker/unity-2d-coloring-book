using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Components
{
	public class TimerComponent : MonoBehaviour
	{
		[SerializeField] private int _seсondsBeforeLaunch;
		[SerializeField] private UnityEvent _onStart;

		void Start()
		{
			StartCoroutine(Countdown());
		}

		IEnumerator Countdown() 
		{
			yield return new WaitForSeconds(_seсondsBeforeLaunch);
			_onStart?.Invoke();
		}
	}
}

