using Features.GameFieldFeature;
using ScriptableObjects;
using UnityEngine;

namespace BrickFeature
{
    public class Brick : MonoBehaviour
    {
        [SerializeField] private Cell[] cells;

        public Color Color { get; set; }


        public void Initialize()
        {
            foreach (var cell in cells)
                cell.Color = Color;
        }

        public bool CheckCollision(Cell[] gameField, Vector2Int fieldSize)
        {
            foreach (var cell in cells)
                if (cell.CheckCollision(gameField, fieldSize)) return true;

            return false;
        }
    }
}