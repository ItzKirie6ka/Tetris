using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BrickConfig", menuName = "Configurations/BrickConfig", order = 1)]
    public class BrickConfig : ScriptableObject
    {
        [SerializeField] private GameObject prefab;


        public GameObject Prefab => prefab;
    }
}
