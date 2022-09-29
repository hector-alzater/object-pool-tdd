using System;
using System.Collections.Generic;
using UnityEngine;

namespace IDED.Scripting.Pool
{
    public class ObjectPool: MonoBehaviour
    {
        [SerializeField] private ObjectPoolInstance template;
        [SerializeField] private int initialSize;
        [SerializeField] private int incrementAmount;
        private Queue<ObjectPoolInstance> _instances;
        
        private void Awake()
        {
            _instances = new Queue<ObjectPoolInstance>();
            AddInstances(initialSize);
        }

        private void AddInstances(int amount)
        {
            throw new NotImplementedException();
        }

        public ObjectPoolInstance Allocate()
        {
            throw new NotImplementedException();
        }

        public void Return(ObjectPoolInstance instance)
        {
            throw new NotImplementedException();
        }
    }
}