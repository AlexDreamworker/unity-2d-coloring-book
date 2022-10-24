using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Components
{
	public class OnStartComponent : MonoBehaviour
	{
		[SerializeField] private UnityEvent _onStart;

		void Start()
		{
			_onStart?.Invoke();
		}
	}
}

