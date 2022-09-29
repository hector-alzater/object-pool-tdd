using UnityEngine;

namespace IDED.Scripting.Pool
{
    public class ObjectPoolInstance : MonoBehaviour
    {
        private Transform _transform;
        private ObjectPool _objectPool;

        private void Awake()
        {
            _transform = GetComponent<Transform>();
        }

        public void SetPool(ObjectPool objectPool)
        {
            _objectPool = objectPool;
        }

        public void Return()
        {
            _objectPool.Return(this);
        }

        internal void Prepare()
        {
            gameObject.SetActive(true);
            _transform.parent = null;
        }

        internal void Disable()
        {
            gameObject.SetActive(false);
            _transform.parent = transform;
            _transform.localPosition = Vector3.zero;
        }
    }
}
