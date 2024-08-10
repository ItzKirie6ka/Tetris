using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BrickConfigs", menuName = "Configurations/BrickConfigs", order = 2)]
    public class BrickConfigs : ScriptableObject
    {
        [SerializeField] private BrickConfig[] configs;

        [SerializeField] private Color[] colors;


        public BrickConfig[] Configs => configs;

        public Color[] Colors => colors;
    }
}
