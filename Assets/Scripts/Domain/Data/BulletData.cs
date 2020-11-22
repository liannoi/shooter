using UnityEngine;

namespace Domain.Data
{
    [CreateAssetMenu]
    public class BulletData : ScriptableObject
    {
        [SerializeField] private PlayerData parent;
        [SerializeField] private float force;

        public float Force => force;
        public Vector3 ParentPosition => parent.Position;
    }
}