using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Domain.Data
{
    [CreateAssetMenu]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private Vector3 position;
        [SerializeField] private float speed;
        private IList<EnemyData> _enemies;

        public Vector3 Position => position;
        public float Score => _enemies.Sum(enemy => enemy.Price);

        public void Initialize(Vector3 defaultPosition)
        {
            position = defaultPosition;
            _enemies = new List<EnemyData>();
        }

        public void Move()
        {
            position += new Vector3(0, 0, Input.GetAxis("Vertical") * speed);
            position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
        }

        public void Collect(EnemyData enemy)
        {
            _enemies.Add(enemy);
        }
    }
}