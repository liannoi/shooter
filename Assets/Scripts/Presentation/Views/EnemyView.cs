using Domain.Data;
using UnityEngine;

namespace Presentation.Views
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private EnemyData _enemy;

        public void Initialize(EnemyData enemy)
        {
            _enemy = enemy;
            prefab.transform.position = _enemy.Position;
        }
    }
}