using ChildPaint.Model.Definition;
using UnityEngine;

namespace ChildPaint.Graphics
{
	public class ColorIndicator : MonoBehaviour
	{
		private SpriteRenderer _renderer;

		void Awake() 
		{
			_renderer = GetComponent<SpriteRenderer>();
		}

		void Update()
		{
			_renderer.color = DefsFacade.I.Color.Color;
		}
	}
}

