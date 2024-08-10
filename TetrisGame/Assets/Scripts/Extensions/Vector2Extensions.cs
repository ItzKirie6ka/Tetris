using UnityEngine;

namespace Extensions
{
    public static class Vector2Extensions
    {
        public static Vector2 AlignedPosition(this Vector2 position, Vector2Int fieldSize)
        {
            return new Vector2(position.x - fieldSize.x / 2, position.y - fieldSize.y / 2);
        }
    }
}
