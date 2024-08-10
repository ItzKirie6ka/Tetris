using Features.GameFieldFeature;
using UnityEngine;

namespace Features.Aligment.GameFieldGeneratorFeature
{
    public interface IGameFieldAligment
    {
        public void Align(Transform container, Cell[] cells, Vector2Int fieldSize, Vector2 cellSize);
    }
}
