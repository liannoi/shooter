using System;
using UnityEngine;

namespace Domain.Data
{
    [CreateAssetMenu]
    public class EnemyData : ScriptableObject
    {
        [SerializeField] private Vector3 position;
        [SerializeField] private float price;

        public Vector3 Position => position;
        public float Price => price;
        public bool IsLive { get; private set; }

        public event Action<EnemyData> Died;

        public void Initialize()
        {
            IsLive = true;
        }

        public void OnDied()
        {
            IsLive = false;
            Died?.Invoke(this);
        }
    }
}