using UnityEngine;

namespace Domain.Data
{
    [CreateAssetMenu]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private Vector3 position;
        [SerializeField] private float speed;

        public Vector3 Position => position;

        public void Initialize(Vector3 defaultPosition)
        {
            position = defaultPosition;
        }

        public void Move()
        {
            position += new Vector3(0, 0, Input.GetAxis("Vertical") * speed);
            position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
        }
    }
}