using _Core_.Car;

namespace _Core_.ObjectPool.Interfaces
{
    public interface ICarPoolObject
    {
        public CarView GetCarFromPool();
        public void RecalculateObjectsInPool();
    }
}