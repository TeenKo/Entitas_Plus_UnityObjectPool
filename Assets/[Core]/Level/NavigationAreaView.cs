using _Core_.Common;
using Entitas;
using UnityEngine;

namespace _Core_.Level
{
    public class NavigationAreaView : MonobehAdvGame
    {
        [SerializeField] private bool isStart;
        [SerializeField] private bool isFinish;
        [SerializeField] private DetectionArea detectionArea;
        public override void Link(IEntity entity)
        {
            base.Link(entity);
            GameEntity.isNavigationArea = true;
            GameEntity.AddBounds(detectionArea.Bounds);
            GameEntity.isStart = isStart;
            GameEntity.isFinish = isFinish;
        }
    }
}
