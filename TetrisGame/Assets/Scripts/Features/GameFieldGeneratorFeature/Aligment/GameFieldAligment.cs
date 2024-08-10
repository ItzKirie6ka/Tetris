using Features.GameFieldFeature;
using UnityEngine;

namespace Features.Aligment.GameFieldGeneratorFeature
{
    public class GameFieldAligment : IGameFieldAligment
    {
        private void AlignContainer(Transform container, Vector2 cellSize, Vector2Int fieldSize)
        {
            if (fieldSize.x < fieldSize.y)
                container.position += new Vector3(cellSize.x / 2, -cellSize.y / 2, 0);

            else if (fieldSize.x > fieldSize.y)
                container.position += new Vector3(-fieldSize.x / 4 + (cellSize.x - cellSize.x / 2), fieldSize.y / 2 + cellSize.y / 2, 0);

            else
                container.position += new Vector3(fieldSize.x / 2 + cellSize.x / 2, fieldSize.x / 2 + cellSize.x / 2, 0);
        }

        private void AlignCells(Cell[] cells, Vector2 cellSize)
        {
            for (var i = 0; i < cells.Length; ++i) 
                cells[i].transform.position *= cellSize;
        }

        public void Align(Transform container, Cell[] cells, Vector2Int fieldSize, Vector2 cellSize)
        {
            AlignContainer(container, cellSize, fieldSize);
            AlignCells(cells, cellSize);
        }
    }
}
