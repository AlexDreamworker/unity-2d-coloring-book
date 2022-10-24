using ChildPaint.Model.Definition;
using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Graphics
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Colorizer : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onMouseDown;
        private SpriteRenderer _renderer;

        void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        void OnMouseDown()
        {
            if (DefsFacade.I.Color.Color == Color.white) return;
            
            _renderer.color = DefsFacade.I.Color.Color;
            _onMouseDown?.Invoke();
        }
    }
}

