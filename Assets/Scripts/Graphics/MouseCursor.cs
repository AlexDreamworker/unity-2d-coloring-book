using UnityEngine;

namespace ChildPaint.Graphics
{
	[RequireComponent(typeof(SpriteRenderer))]
	public class MouseCursor : MonoBehaviour
	{
		[SerializeField] private Sprite _normal;
		[SerializeField] private Sprite _clicked;

		private SpriteRenderer _renderer;

		void Start() 
		{
			Cursor.visible = false;
			_renderer = GetComponent<SpriteRenderer>();
		}

		void Update()
		{
			var cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = new Vector3(cursorPosition.x, cursorPosition.y, transform.position.z);

			if (Input.GetMouseButtonDown(0)) 
				_renderer.sprite = _clicked;
			else if (Input.GetMouseButtonUp(0)) 
				_renderer.sprite = _normal;
		}
	}
}

