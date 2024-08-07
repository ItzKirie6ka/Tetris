using ScriptableObjects;
using UnityEngine;

namespace PlayerPreferences
{
    public class GameFieldGeneratorPrefs : MonoBehaviour
    {
        private static GameFieldGeneratorPrefs _instance;

        public static GameFieldGeneratorPrefs Instance { get => _instance; private set => _instance = value; }

        public FieldSize FieldSize { private get; set; }


        private void Awake()
        {
            if (Instance != null)
                Destroy(Instance);

            Instance = this;
        }

        public Vector2Int GetFieldSize(GameFieldGeneratorConfig config)
        {
            return FieldSize switch
            {
                FieldSize.Small => config.SmallFieldSize,
                FieldSize.Medium => config.MediumFieldSize,
                FieldSize.Large => config.LargeFieldSize,
                _ => config.MediumFieldSize
            };
        }
    }
}