using UnityEngine;

namespace ChildPaint.Model.Definition
{
	[CreateAssetMenu(menuName = "Defs/ColorDef", fileName = "ColorDef")]
	public class ColorDef : ScriptableObject
	{
		[SerializeField] private Color _color;

		public Color Color => _color;

		public void Set(Color color) 
		{
			_color = color;
		}
	}
}

