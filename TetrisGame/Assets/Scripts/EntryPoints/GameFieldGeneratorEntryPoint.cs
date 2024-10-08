using Features.Aligment.GameFieldGeneratorFeature;
using Features.GameFieldFeature;
using Features.GameFieldGeneratorFeature;
using PlayerPreferences;
using ScriptableObjects;
using UnityEngine;

namespace EntryPoints
{
    public class GameFieldGeneratorEntryPoint : MonoBehaviour
    {
        [SerializeField] private GameFieldGeneratorConfig config;

        [SerializeField] private Transform container;


        private void Start()
        {
            var gameFieldPrefs = GameFieldGeneratorPrefs.Instance;

            gameFieldPrefs.FieldSize = FieldSize.Small;

            var fieldSize = gameFieldPrefs.GetFieldSize(config);

            var gameField = new GameField
                (
                new GameFieldGenerator(
                    config,
                    fieldSize, 
                    container, 
                    new GameFieldAligment()
                ),
                fieldSize
                );

            gameField.Generate();
        }
    }
}