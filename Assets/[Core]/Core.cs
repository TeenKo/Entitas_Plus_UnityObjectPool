using UnityEngine;

namespace _Core_
{
    public class Core : MonoBehaviour
    {
        private CoreSystems _coreSystems;
        private Contexts _contexts;

        private void Awake()
        {
            _contexts = Contexts.sharedInstance;
            _coreSystems = new CoreSystems(_contexts);
        }

        private void Start()
        {
            _coreSystems.Initialize();
        }

        private void Update()
        {
            _coreSystems.Execute();
        }

        private void LateUpdate()
        {
            _coreSystems.Cleanup();
        }
    }
}
