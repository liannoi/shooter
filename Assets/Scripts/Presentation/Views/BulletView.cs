using Domain.Data;
using UnityEngine;

namespace Presentation.Views
{
    public class BulletView : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Rigidbody prefabRigidbody;
        private BulletData _bullet;

        public void Initialize(BulletData bullet)
        {
            _bullet = bullet;
            prefab.transform.position = _bullet.ParentPosition;
            prefabRigidbody.AddForce(prefab.transform.forward * _bullet.Force, ForceMode.Impulse);
            Destroy(gameObject, 4);
        }
    }
}