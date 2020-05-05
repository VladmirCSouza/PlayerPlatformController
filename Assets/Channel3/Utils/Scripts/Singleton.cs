using UnityEngine;

namespace Channel3.Utils.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        // The instance is accessible only by the getter
        private static T m_Instance;
        public static bool m_isQuitting;

        public static T Instance {
            get {
                if (m_Instance == null)
                {
                    // Making sure that there's no other instances of the same type
                    m_Instance = FindObjectOfType<T>();

                    if (m_Instance == null)
                    {
                        // Create a instance of the type
                        GameObject obj = new GameObject();
                        obj.name = typeof(T).Name;
                        m_Instance = obj.AddComponent<T>();
                    }
                }
                return m_Instance;
            }
        }

        // Can be overriden in a derived class
        public virtual void Awake()
        {
            if (m_Instance == null)
            {
                //If null, instance is now the singleton instance of the assigned type
                m_Instance = this as T;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                //Destroy duplicate instance
                Destroy(gameObject);
            }
        }
    }
}
