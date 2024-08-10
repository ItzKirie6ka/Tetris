using Features.GameFieldGeneratorFeature;
using UnityEngine;

namespace Features.GameFieldFeature
{
    public class GameField
    {
        private readonly IGameFieldGenerator _generator;

        private readonly Vector2Int _fieldSize;

        private Cell[] _cells;


        public GameField(IGameFieldGenerator generator, Vector2Int fieldSize)
        {
            _generator = generator;
            _fieldSize = fieldSize;
        }

        public void Generate()
        {
            _cells = _generator.Generate();
        }
    }
}
