using _Core_.Car;
using _Core_.Common;
using _Core_.ObjectPool.Interfaces;
using Entitas;
using UnityEngine;
using UnityEngine.Pool;

namespace _Core_.Spawner
{
    public class CarObjectPool : MonobehAdvGame, ICarPoolObject
    {
        [SerializeField] private CarView carPrefab;
        [SerializeField] private int objectsCount;

        private ObjectPool<CarView> _carPool;

        public override void Link(IEntity entity)
        {
            InitPoolObject();
                
            base.Link(entity);
            GameEntity.isPoolObject = true;
            GameEntity.AddCarPoolObject(this);
        }

        private void InitPoolObject()
        {
            _carPool = new ObjectPool<CarView>(
                CreatePoolObject,
                OnTakeFromPool,
                OnReturnToPool,
                OnDestroyObject,
                false,
                200,
                100);
            
            for (var i = 0; i < objectsCount; i++) _carPool.Get();
        }

        public CarView CreatePoolObject()
        {
            var instance = Instantiate(carPrefab, transform.position, Quaternion.identity, transform);
            instance.Disable += ReturnToObjectPool;
            instance.gameObject.SetActive(false);
            
            return instance;
        }

        public CarView GetCarFromPool()
        {
            return _carPool.Get();
        }

        public void ReturnToObjectPool(MonobehAdv instance)
        {
            _carPool.Release((CarView)instance);
        }

        public void OnTakeFromPool(CarView instance)
        {
            instance.TakeFromPool();
        }

        public void OnReturnToPool(CarView instance)
        {
            instance.ReturnToPool();
        }

        public void OnDestroyObject(CarView instance)
        {
            Destroy(instance.gameObject);
        }

        public void RecalculateObjectsInPool()
        {
            GameEntity.ReplaceTotalPoolSize(_carPool.CountAll);
            GameEntity.ReplaceActiveObjects(_carPool.CountActive);
        }
    }
}