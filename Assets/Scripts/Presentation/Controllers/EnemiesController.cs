using Application.Storage;
using JetBrains.Annotations;
using Presentation.Views;
using UnityEngine;

namespace Presentation.Controllers
{
    public class EnemiesController : MonoBehaviour
    {
        [SerializeField] private EnemiesCollection enemies;
        [SerializeField] private GameObject prefab;
        [SerializeField] [CanBeNull] private Transform viewParent;

        private void Start()
        {
            foreach (var enemy in enemies.Enemies)
            {
                enemy.Initialize();
                Instantiate(prefab, viewParent).GetComponent<EnemyView>().Initialize(enemy);
            }
        }
    }
}