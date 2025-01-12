using UnityEngine;

public class ScriptableSingleton<T> : ScriptableObject where T : ScriptableObject {
    public static T Instance {
        get { return GetInstance(); }
    }
    private static T s_instance;

    private static T GetInstance() {
        if (s_instance != null) return s_instance;

        T[] singletons = Resources.LoadAll<T>("");
        if (singletons == null || singletons.Length < 1) {
            throw new System.Exception($"No {typeof(T).Name} Singleton Found");
        }

        if (singletons.Length > 1) {
            Debug.LogWarning($"More than one {typeof(T).Name} Singleton Found");
        }

        s_instance = singletons[0];
        Debug.Log($"SO Manager Instance {s_instance.GetInstanceID()} Initialized");
        return s_instance;
    }
    
}
