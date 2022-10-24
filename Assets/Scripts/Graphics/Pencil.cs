using ChildPaint.Model.Definition;
using UnityEngine;

namespace ChildPaint.Graphics
{
    public class Pencil : MonoBehaviour
    {
        [SerializeField] private Color _color;

        public void SetColor() 
        {
            DefsFacade.I.Color.Set(_color);
        }
    }
}

