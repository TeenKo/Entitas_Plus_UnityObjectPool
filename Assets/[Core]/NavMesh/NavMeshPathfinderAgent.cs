using System;
using _Core_.Common.Interfaces;
using _Core_.NavMesh.Interfaces;
using UnityEngine;
using UnityEngine.AI;

namespace _Core_.NavMesh
{
    public class NavMeshPathfinderAgent : MonoBehaviour, IGameEntityView, IPathfinderAgent, IMoveStateRemovedListener
    {
        [SerializeField] private NavMeshAgent navMeshAgent;

        private Action _onReached;
        private bool _isMoving;

        public void Link(GameEntity entity)
        {
            entity.AddPathfinderAgent(this);

            navMeshAgent.enabled = true;
        }

        private void Update()
        {
            if (!_isMoving) return;
            if (DistanceToNextPoint() < navMeshAgent.stoppingDistance)
            {
                StopMoving();
            }
        }

        private void StopMoving()
        {
            navMeshAgent.enabled = false;
            _isMoving = false;

            if (_onReached == null) return;
            var reachedEvent = _onReached;
            _onReached = null;
            reachedEvent.Invoke();
        }

        public void OffAgent()
        {
            navMeshAgent.enabled = false;
            _isMoving = false;
        }

        public void MoveToDestination(Transform target, Action onComplete)
        {
            navMeshAgent.enabled = true;
            navMeshAgent.SetDestination(target.position);
            _onReached = onComplete;
            _isMoving = true;
        }

        public void MoveToDestination(Transform target)
        {
            navMeshAgent.enabled = true;
            navMeshAgent.SetDestination(target.position);
            _isMoving = true;
        }

        public void MoveToDestination(Vector3 position, Action onComplete)
        {
            navMeshAgent.enabled = true;
            navMeshAgent.SetDestination(position);
            _onReached = onComplete;
            _isMoving = true;
        }

        public void StopMovement()
        {
            StopMoving();
        }

        private float DistanceToNextPoint()
        {
            var transformVector = navMeshAgent.transform.position;
            var navMeshDistanceVector = navMeshAgent.destination;
            navMeshDistanceVector.y = 0;
            transformVector.y = 0;

            var distance = Vector3.Distance(transformVector, navMeshDistanceVector);

            return distance;
        }

        public void OnMoveStateRemoved(GameEntity entity)
        {
            if (navMeshAgent.enabled) StopMoving();
        }
    }
}