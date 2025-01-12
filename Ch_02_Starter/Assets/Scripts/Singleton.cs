
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: MonoBehaviour {
    private static T s_instance;
    public static T Instance {
        get { return GetInstance(); }
    }

    private static T GetInstance() {
        if (s_instance != null) return s_instance;

        s_instance = FindAnyObjectByType<T>();
        if (s_instance != null) return s_instance;

        CreateNewInstance();
        return s_instance;
    }
    
    private static void CreateNewInstance() {
        GameObject singletonObject = new() {
            name = $"{typeof(T).Name} (Persists)"
        };

        s_instance = singletonObject.AddComponent<T>();

        DontDestroyOnLoad(s_instance);
        Debug.Log($"Manager Instance {s_instance.GetInstanceID()} Initialized");
    }
    
}
