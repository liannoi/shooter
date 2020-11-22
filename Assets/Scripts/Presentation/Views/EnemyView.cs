using Domain.Data;
using UnityEngine;

namespace Presentation.Views
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private EnemyData _enemy;

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log($"+ {_enemy.Price}");
            _enemy.OnDied();
            Destroy(gameObject);
        }

        public void Initialize(EnemyData enemy)
        {
            _enemy = enemy;
            prefab.transform.position = _enemy.Position;
        }
    }
}