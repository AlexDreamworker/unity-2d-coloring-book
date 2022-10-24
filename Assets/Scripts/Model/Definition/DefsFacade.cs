using UnityEngine;

namespace ChildPaint.Model.Definition
{
	[CreateAssetMenu(menuName = "Defs/DefsFacade", fileName = "DefsFacade")]
	public class DefsFacade : ScriptableObject
	{
		[SerializeField] private ColorDef _color;
		[SerializeField] private LanguageDef _language;

		public ColorDef Color => _color;
		public LanguageDef Language => _language;

		public static DefsFacade _instance;
		public static DefsFacade I => _instance == null ? LoadDefs() : _instance;

		static DefsFacade LoadDefs() 
		{
			return _instance = Resources.Load<DefsFacade>("DefsFacade");
		}
	}
}

