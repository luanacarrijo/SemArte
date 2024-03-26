using FMODUnity;
using System;
using UnityEngine;

namespace Template.Game
{
    public static class Game
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Bootstrap()
        {
#if UNITY_EDITOR
            if (ShouldSkip())
            {
                return;
            }
#endif
            // Force initialize FMOD
            _ = RuntimeManager.StudioSystem;

            if (Resources.Load("Global") is not GameObject globalPrefab)
            {
                throw new ApplicationException("'Global' prefab is missing from Assets/Resources");
            }
            
            GameObject global = UnityEngine.Object.Instantiate(globalPrefab);
            global.name = "[Global]";
            UnityEngine.Object.DontDestroyOnLoad(global);
        }

#if UNITY_EDITOR
        private static bool ShouldSkip()
        {
            return true;
        }
#endif // UNITY_EDITOR
    }
}
