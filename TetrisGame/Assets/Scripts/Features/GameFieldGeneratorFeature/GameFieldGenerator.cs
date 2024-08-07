using Features.GameFieldFeature;
using ScriptableObjects;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

namespace Features.GameFieldGeneratorFeature
{
    public class GameFieldGenerator
    {
        private readonly GameFieldGeneratorConfig _config;

        private readonly Vector2Int _fieldSize;

        private readonly Transform _container;


        public GameFieldGenerator(GameFieldGeneratorConfig config, Vector2Int fieldSize, Transform container)
        {
            _config = config;
            _fieldSize = fieldSize;
            _container = container;
        }
         
        public void Generate()
        {
            var cells = new Cell[_fieldSize.x, _fieldSize.y];

            for (var y = 0; y < _fieldSize.y; ++y)
                for (var x = 0; x < _fieldSize.x; ++x)
                    InitializeCell(ref cells[x, y], x, y);

            //TODO separate aligment

            _container.position += new Vector3(_config.CellSize.x / 2, _config.CellSize.y / 2, 0);

            for (var y = 0; y < _fieldSize.y; ++y)
                for (var x = 0; x < _fieldSize.x; ++x)
                    cells[x, y].transform.position *= _config.CellSize;
        }

        private Vector2 GetAlignedPosition(Vector2 position)
        {
            return new Vector2(position.y - _fieldSize.y / 2, position.x - _fieldSize.x / 2);
        }

        private void InitializeCell(ref Cell cell, int y, int x)
        {
            var cellGameObject = Object.Instantiate(_config.CellPrefab, _container);

            cellGameObject.transform.localScale = new Vector2(_config.CellSize.x, _config.CellSize.y);

            cellGameObject.transform.position = GetAlignedPosition(new Vector2(x, y));

            cell = cellGameObject.AddComponent<Cell>();

            cell.SetType
                (
                cell.CheckType(_fieldSize),
                _config
                );
        }
    }
}