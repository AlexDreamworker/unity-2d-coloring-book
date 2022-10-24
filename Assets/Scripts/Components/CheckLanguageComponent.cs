using ChildPaint.Model.Definition;
using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Components
{
	public class CheckLanguageComponent : MonoBehaviour
	{
		[SerializeField] private UnityEvent _onRussian;
		[SerializeField] private UnityEvent _onEnglish;

		void OnEnable()
		{
			var lang = DefsFacade.I.Language.LanguageType;

			if (lang == 0)
				_onRussian?.Invoke();
			else 
				_onEnglish?.Invoke();
		}
	}
}

