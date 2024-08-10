using Features.Aligment.GameFieldGeneratorFeature;
using Extensions;
using Features.GameFieldFeature;
using ScriptableObjects;
using UnityEngine;

namespace Features.GameFieldGeneratorFeature
{
    public class GameFieldGenerator : IGameFieldGenerator
    {
        private readonly GameFieldGeneratorConfig _config;

        private readonly Vector2Int _fieldSize;

        private readonly Transform _container;

        private readonly IGameFieldAligment aligment;
        

        public GameFieldGenerator(GameFieldGeneratorConfig config, Vector2Int fieldSize, Transform container, IGameFieldAligment aligment)
        {
            _config = config;
            _fieldSize = fieldSize;
            _container = container;
            this.aligment = aligment;
        }
         
        public Cell[] Generate()
        {
            var cells = new Cell[_fieldSize.x * _fieldSize.y];

            InitializeGameField(cells);

            aligment.Align
                (
                _container, 
                cells,
                _fieldSize,
                _config.CellSize
                );

            return cells;
        }

        private void InitializeGameField(Cell[] cells)
        {
            var cellPosition = new Vector2Int(0, 0);

            for (var i = 0; i < cells.Length; ++i)
            {
                if (cellPosition.x % _fieldSize.x == 0)
                {
                    cellPosition.x = 0;
                    ++cellPosition.y;
                }

                Debug.Log($"x={cellPosition.x}, y={cellPosition.y}");

                InitializeCell(ref cells[i], cellPosition);

                ++cellPosition.x;
            }       
        }

        private void InitializeCell(ref Cell cell, Vector2 position)
        {
            var cellGameObject = Object.Instantiate(_config.CellPrefab, _container);

            cellGameObject.transform.localScale = new Vector2(_config.CellSize.x, _config.CellSize.y);

            cellGameObject.transform.position = position.AlignedPosition(_fieldSize);

            cell = cellGameObject.AddComponent<Cell>();

            cell.SetType
                (
                cell.CheckType(_fieldSize),
                _config
                );
        }
    }
}