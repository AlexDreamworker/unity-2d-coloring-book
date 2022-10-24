using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Components
{
	public class VisibleComponent : MonoBehaviour
	{
		[SerializeField] private UnityEvent _onEnable;
		[SerializeField] private UnityEvent _onDisable;

		void OnEnable()
		{
			_onEnable?.Invoke();
		}

		void OnDisable()
		{
			_onDisable?.Invoke();
		}
	}
}

