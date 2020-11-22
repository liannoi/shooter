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

        private void Start()
        {
            player.Initialize(new Vector3(0, 1.75F, -20));
            Instantiate(prefab, viewParent).GetComponent<PlayerView>().Initialize(player);
        }

        private void Update()
        {
            player.Move();
        }
    }
}