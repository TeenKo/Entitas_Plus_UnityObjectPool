using Entitas;
using UnityEngine;

namespace _Core_.Touch
{
    public class TouchExecuteSystem : IExecuteSystem
    {
        private readonly InputEntity _inputDataEntity;
        public TouchExecuteSystem(Contexts contexts)
        {
            contexts.input.isTouchData = true;
            _inputDataEntity = contexts.input.touchDataEntity;

            _inputDataEntity.ReplaceTouchDownPosition(Vector2.zero);
            _inputDataEntity.ReplaceTouchMovePosition(Vector2.zero);
            _inputDataEntity.ReplaceTouchUpPosition(Vector2.zero);
            _inputDataEntity.ReplaceTouchDelta(Vector2.zero);
        }

        public void Execute()
        {
#if UNITY_EDITOR || PLATFORM_STANDALONE_OSX
            Delta(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));

            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                Began();
                return;
            }
            if (UnityEngine.Input.GetMouseButton(0))
            {
                Moved();
                return;
            }
            if (UnityEngine.Input.GetMouseButtonUp(0)) Ended();
#elif !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IOS)
            if (UnityEngine.Input.touchCount != 1) return;

            Delta(UnityEngine.Input.GetTouch(0).deltaPosition);

            if (UnityEngine.Input.GetTouch(0).phase == TouchPhase.Began)  {
                Began();
                return;
            }
            if (UnityEngine.Input.GetTouch(0).phase == TouchPhase.Moved ||
                UnityEngine.Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                Moved();
                return;
            }
            if (UnityEngine.Input.GetTouch(0).phase == TouchPhase.Ended) Ended();
#endif
        }

        private void Began()
        {
            _inputDataEntity.ReplaceTouchPhase(TouchPhase.Began);
            _inputDataEntity.ReplaceTouchDownPosition(UnityEngine.Input.mousePosition);
        }

        private void Moved()
        {
            _inputDataEntity.ReplaceTouchPhase(TouchPhase.Moved);
            _inputDataEntity.ReplaceTouchMovePosition(UnityEngine.Input.mousePosition);
        }

        private void Ended()
        {
            _inputDataEntity.ReplaceTouchPhase(TouchPhase.Ended);
            _inputDataEntity.ReplaceTouchUpPosition(UnityEngine.Input.mousePosition);
        }

        private void Delta(Vector2 delta)
        {
            _inputDataEntity.ReplaceTouchDelta(delta);
        }
    }
}