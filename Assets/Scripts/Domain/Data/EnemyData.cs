using UnityEngine;

namespace Domain.Data
{
    [CreateAssetMenu]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private Vector3 position;

        public Vector3 Position => position;
    }
}