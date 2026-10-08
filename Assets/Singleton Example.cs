using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    public static SingletonExample Instance { get; private set; }

    public int enemiesDefeated { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        Debug.Log(enemiesDefeated);
    }

    private void FruitSummoner(Transform transform)
    {
        //Have a random fruit spawn at the location of the dead enemy via the factory
    }
}
