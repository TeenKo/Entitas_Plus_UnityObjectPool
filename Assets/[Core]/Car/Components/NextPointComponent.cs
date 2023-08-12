using Entitas;
using UnityEngine;

namespace _Core_.Car.Components
{
    [Game]
    public class NextPointComponent : IComponent
    {
        public Vector3 nextPoint;
        public int index;
        public bool isFinish;
        public bool isStart;
    }
}