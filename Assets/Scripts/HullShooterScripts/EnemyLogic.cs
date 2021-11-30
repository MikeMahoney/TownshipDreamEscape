using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLogic : MonoBehaviour
{
    public GameObject enemyBasic;
    public GameObject enemySpecial;
    public int enemyCount = 20;
    void Start ()
    {
        InvokeRepeating("CreateEnemy", 5, 2);
    }

    void CreateEnemy()
    {
        if (enemyCount > 0) {
            int randomZ = Random.Range(0, 20);
            Vector3 enemyPosition = new Vector3(transform.position.x, 58.28f, transform.position.z-randomZ);

            if (enemyCount == 5 || enemyCount == 10 || enemyCount == 15) {
                GameObject clone = Instantiate(enemySpecial, enemyPosition, enemySpecial.transform.rotation) as GameObject;
            } else {
                GameObject clone = Instantiate(enemyBasic, enemyPosition, enemyBasic.transform.rotation) as GameObject;
            }

            enemyCount -= 1;
        } else {
            CancelInvoke();
            SceneManager.LoadScene(1);
        }
    }
}
