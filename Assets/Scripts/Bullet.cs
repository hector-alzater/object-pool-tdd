using IDED.Scripting.Pool;
using UnityEngine;

[RequireComponent(typeof (ObjectPoolInstance))]
public class Bullet : MonoBehaviour
{
    private ObjectPoolInstance _objectPoolInstance;
    
    private void Awake()
    {
        _objectPoolInstance = GetComponent<ObjectPoolInstance>();
    }

    private void OnCollisionEnter(Collision other)
    {
        _objectPoolInstance.Return();
    }
}
