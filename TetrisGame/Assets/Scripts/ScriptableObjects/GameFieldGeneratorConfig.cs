using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new GameFieldGeneratorConfig", menuName = "Configurations/GameFieldGeneratorConfig", order = 0)]
    public class GameFieldGeneratorConfig : ScriptableObject
    {
        [SerializeField] private GameObject cellPrefab;

        [SerializeField] private Vector2 cellSize;

        [SerializeField] private Color borderColor;

        [SerializeField] private Color emptyColor;

        [SerializeField] private Vector2Int smallFieldSize;

        [SerializeField] private Vector2Int mediumFieldSize;

        [SerializeField] private Vector2Int largeFieldSize;


        public GameObject CellPrefab => cellPrefab;

        public Vector2 CellSize => cellSize;

        public Color BorderColor => borderColor;

        public Color EmptyColor => emptyColor;

        public Vector2Int SmallFieldSize => smallFieldSize + new Vector2Int(2, 2);

        public Vector2Int MediumFieldSize => mediumFieldSize + new Vector2Int(2, 2);

        public Vector2Int LargeFieldSize => largeFieldSize + new Vector2Int(2, 2);
    }
}