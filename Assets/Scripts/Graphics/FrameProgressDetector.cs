using UnityEngine;
using UnityEngine.Events;

namespace ChildPaint.Graphics
{
    public class FrameProgressDetector : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onProgress;
        private SpriteRenderer[] _layers;

        void Start()
        {
            _layers = GetComponentsInChildren<SpriteRenderer>();
        } 

        void Update()
        {
            for (int i = 0; i < _layers.Length - 1; i++) 
                if (_layers[i].color == Color.white) return;

            _onProgress?.Invoke();
            this.enabled = false;   
        }
    }
}





















