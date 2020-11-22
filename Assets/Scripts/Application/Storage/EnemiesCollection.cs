using System.Collections.Generic;
using Domain.Data;
using UnityEngine;

namespace Application.Storage
{
    public class EnemiesCollection : MonoBehaviour
    {
        [SerializeField] private EnemyData[] enemies;

        public IEnumerable<EnemyData> Enemies => enemies;
    }
}