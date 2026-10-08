using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SingletonExample.Instance.enemiesDefeated += 1;

        //SingletonExample.Instance.FruitSummoner(this.transform.position);

        Destroy(this.gameObject);
    }
}
