using ScriptableObjects;
using UnityEngine;

namespace Features.GameFieldFeature
{
    public class Cell : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;

        public Color Color
        {
            private get => _spriteRenderer.color;
            set => _spriteRenderer.color = value;
        }

        public CellType Type { get; private set; }


        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void SetType(CellType type,GameFieldGeneratorConfig config)
        {
            Type = type;
            
            Color = Type switch
            {
                CellType.Border => config.BorderColor,
                CellType.Empty => config.EmptyColor,
            };
        }

        public CellType CheckType(Vector2 fieldSize) => IsBorder(fieldSize) ? CellType.Border : CellType.Empty;
 
        private bool IsBorder(Vector2 fieldSize)
        {
            var cellPosition = transform.position;

            var isBorder = false;

            var borderPosition = fieldSize / 2;

            if (cellPosition.y == -borderPosition.y || cellPosition.y == borderPosition.y - 1) isBorder = true;

            else if (cellPosition.x == -borderPosition.x || cellPosition.x == borderPosition.x - 1) isBorder = true;

            return isBorder;
        }
    }
}
