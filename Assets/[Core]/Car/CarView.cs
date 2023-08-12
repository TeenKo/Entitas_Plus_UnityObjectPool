using _Core_.Common;
using _Core_.NavMesh;
using Entitas;
using UnityEngine;
using UnityEngine.AI;

namespace _Core_.Car
{
    public class CarView : MonobehAdvGame
    {
        [SerializeField] private NavMeshPathfinderAgent pathfinderAgent;
        
        private NavMeshAgent _navMeshAgent;
        public override void Link(IEntity entity)
        {
            base.Link(entity);
            pathfinderAgent.Link(GameEntity);

            GameEntity.isCar = true;
        }

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            Disable?.Invoke(this);
        }

        public void ReturnToPool()
        {
            _navMeshAgent.enabled = false;
            gameObject.SetActive(false);
        }
        
        public void TakeFromPool()
        {
            _navMeshAgent.enabled = true;
            gameObject.SetActive(true);
        }
    }
}
