using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "GameFieldGeneratorConfig", menuName = "Configurations/GameFieldGeneratorConfig", order = 0)]
    public class GameFieldGeneratorConfig : ScriptableObject
    {
        [SerializeField] private GameObject cellPrefab;

        [SerializeField] private Vector2 cellSize;

        [SerializeField] private Color borderColor;

        [SerializeField] private Color emptyColor;

        [SerializeField] private Color[] bricksColors;

        [SerializeField] private Vector2Int smallFieldSize;

        [SerializeField] private Vector2Int mediumFieldSize;

        [SerializeField] private Vector2Int largeFieldSize;


        public GameObject CellPrefab => cellPrefab;

        public Vector2 CellSize => cellSize;

        public Color BorderColor => borderColor;

        public Color EmptyColor => emptyColor;

        public Color[] BricksColor => bricksColors;

        public Vector2Int SmallFieldSize => smallFieldSize;

        public Vector2Int MediumFieldSize => mediumFieldSize;

        public Vector2Int LargeFieldSize => largeFieldSize;
    }
}