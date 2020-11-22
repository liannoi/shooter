using System.Linq;
using Application.Storage;
using Domain.Data;
using JetBrains.Annotations;
using Presentation.Views;
using UnityEngine;

namespace Presentation.Controllers
{
    public class PlayersController : MonoBehaviour
    {
        [SerializeField] private PlayerData player;
        [SerializeField] private GameObject prefab;
        [SerializeField] [CanBeNull] private Transform viewParent;
        [SerializeField] private EnemiesCollection enemies;

        private void Start()
        {
            SetupPlayer();
            SubscribeOnEnemyDied();
        }

        private void Update()
        {
            player.Move();
        }

        // Events.

        private void EnemyOnDied(EnemyData enemy)
        {
            player.Collect(enemy);

            if (enemies.Enemies.All(e => !e.IsLive)) Debug.Log($"Total: {player.Score}");
        }

        // Helpers.

        private void SubscribeOnEnemyDied()
        {
            foreach (var enemy in enemies.Enemies) enemy.Died += EnemyOnDied;
        }

        private void SetupPlayer()
        {
            player.Initialize(new Vector3(0, 1.75F, -20));
            Instantiate(prefab, viewParent).GetComponent<PlayerView>().Initialize(player);
        }
    }
}