using UnityEngine;

namespace ChildPaint.Graphics 
{
    public class Fading : MonoBehaviour
    {
        [SerializeField] private Texture2D _fadingTexture;

        private float _fadeSpeed = 0.8f;
        private float _alpha = 1f;
        private float _fadeDir = -1;
        private int _drawDepth = -1000;

        void OnGUI()
        {
            _alpha += _fadeDir * _fadeSpeed * Time.deltaTime;
            _alpha = Mathf.Clamp01(_alpha);

            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, _alpha);
            GUI.depth = _drawDepth;
            GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), _fadingTexture);
        }

        public float Fade(float dir)
        {
            _fadeDir = dir;
            return _fadeSpeed;
        }
    }
}

