using Domain.Data;
using UnityEngine;

namespace Presentation.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private PlayerData _player;

        private void Update()
        {
            UpdatePosition();
        }

        public void Initialize(PlayerData player)
        {
            _player = player;
            UpdatePosition();
        }

        // Helpers.

        private void UpdatePosition()
        {
            prefab.transform.position = _player.Position;
        }
    }
}