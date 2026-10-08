using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SingletonExample.Instance.enemiesDefeated += 1;

        Destroy(this.gameObject);
    }
}
