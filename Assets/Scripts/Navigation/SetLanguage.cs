using ChildPaint.Model.Definition;
using UnityEngine;

namespace ChildPaint.Navigation
{
	public class SetLanguage : MonoBehaviour
	{
		public void SetRussian() => DefsFacade.I.Language.SetRussian();
		public void SetEnglish() => DefsFacade.I.Language.SetEnglish();
	}
}

