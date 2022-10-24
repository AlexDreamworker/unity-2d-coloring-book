using UnityEngine;
using UnityEngine.EventSystems;

namespace ChildPaint.UI
{
	public class DragUI : MonoBehaviour
	{
		[SerializeField] private Canvas _canvas;

		public void DragHandler(BaseEventData data) 
		{
			PointerEventData pointerData = (PointerEventData)data;

			Vector2 position;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(
				(RectTransform)_canvas.transform,
				pointerData.position,
				_canvas.worldCamera,
				out position);

			transform.position = _canvas.transform.TransformPoint(position);
		}
	}
}

