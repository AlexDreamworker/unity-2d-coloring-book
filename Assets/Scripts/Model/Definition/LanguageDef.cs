using System;
using UnityEngine;

namespace ChildPaint.Model.Definition
{
	[CreateAssetMenu(menuName = "Defs/LanguageDefs", fileName = "LanguageDefs")]
	public class LanguageDef : ScriptableObject
	{
		[SerializeField] private LanguageType _languageType;

		public LanguageType LanguageType => _languageType;

		public void SetRussian() 
		{
			_languageType = LanguageType.russian;
		}

		public void SetEnglish() 
		{
			_languageType = LanguageType.english;
		}	
	}

	[Serializable]
	public enum LanguageType
	{
		russian,
		english
	}
}

