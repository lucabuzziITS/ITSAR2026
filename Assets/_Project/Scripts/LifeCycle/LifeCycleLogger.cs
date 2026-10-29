using UnityEngine;

public class LifeCycleLogger : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Eseguo Awake di {gameObject.name}");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Eseguo Start di {gameObject.name}");
    }
    
    // Update is called once per frame
        void Update()
    {
                Debug.Log($"Eseguo Update di {gameObject.name}");
    }

    private void FixedUpdate()
    {
        Debug.Log($"Eseguo FixedUpate di {gameObject.name}");
    }

    private void LateUpdate()
    {
        Debug.Log($"Eseguo LateUpdate di {gameObject.name}");
    }

    private void OnDestroy()
    {
        Debug.Log($"Eseguo OnDestroy di {gameObject.name}");
    }

}
