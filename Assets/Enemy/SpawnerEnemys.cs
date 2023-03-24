using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemys : MonoBehaviour
{
   public GameObject enemy;
    public int xPos;
    public int zPos;
    public int numero;

    private void Start()
    {
        StartCoroutine(EnemySpaw());
    }

    IEnumerator EnemySpaw()
    {
        while(numero < 5)
        {
            xPos = Random.Range(100, 300);
            zPos = Random.Range(-100, 100);
            Instantiate(enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(.1f);
            numero += 1;

        }
    }
}
