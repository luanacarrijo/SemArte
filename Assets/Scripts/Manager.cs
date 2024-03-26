using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Template.Game
{
    [DisallowMultipleComponent]
    public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
    {
        private static T instance;
        
        protected static T Instance
        {
            get
            {
                Assert.IsNotNull(instance, $"{typeof(T)} is missing");
                return instance;
            }
        }

        private void Awake()
        {
            if (instance != null)
            {
                Debug.LogWarning($"{gameObject.name} is trying to create an additional instance of {typeof(T)}, destroying...");
                Destroy(this.gameObject);
            }

            instance = this as T;
            OnCreateManager();
        }

        private void OnDestroy()
        {
            if (instance != this)
                return;
            OnDestroyManager();
            instance = null;
        }

        protected abstract void OnCreateManager();
        protected abstract void OnDestroyManager();
    }
}
