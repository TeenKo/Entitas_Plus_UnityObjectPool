using UnityEngine;

namespace _Core_.Common
{
    public class SetCamera : MonoBehaviour
    {
        [SerializeField] private bool rotateX;
        [SerializeField] private bool rotateY;
        [SerializeField] private bool rotateZ;
        [SerializeField] private Transform[] ignoreRotateElements;
        
        
        private void Start()
        {
            GetComponent<Canvas>().worldCamera = UnityEngine.Camera.main;
            var mainCameraRotation = UnityEngine.Camera.main.transform.rotation.eulerAngles;
            var myRotation = transform.rotation.eulerAngles;

            if (rotateX)
            {
                myRotation.x = mainCameraRotation.x;
            }
            
            if (rotateY)
            {
                myRotation.y = mainCameraRotation.y;
            }
            
            if (rotateZ)
            {
                myRotation.z = mainCameraRotation.z;
            }
            
            transform.rotation = Quaternion.Euler(myRotation);
            
            foreach (var ignoreRotateElement in ignoreRotateElements)
            {
                ignoreRotateElement.localRotation = Quaternion.Euler(myRotation);
            }
        }
    }
}
