using Domain.Data;
using JetBrains.Annotations;
using Presentation.Views;
using UnityEngine;

namespace Presentation.Controllers
{
    public class BulletsController : MonoBehaviour
    {
        [SerializeField] private BulletData bullet;
        [SerializeField] private GameObject prefab;
        [SerializeField] [CanBeNull] private Transform viewParent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Instantiate(prefab, viewParent).GetComponent<BulletView>().Initialize(bullet);
        }
    }
}