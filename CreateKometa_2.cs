using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKometa_2 : MonoBehaviour
{
    public GameObject kometa;
    private bool isSpawn = false;

    private void Update()
    {
        if (!isSpawn)
        {
            StartCoroutine(spawnKometas());
            isSpawn = true;
        }

    }

    IEnumerator spawnKometas()
    {
        while (true)
        {
            Instantiate(kometa, new Vector2(Random.Range(-8.38f, 8.38f), 8f), Quaternion.identity);
            yield return new WaitForSeconds(2f); // Добавляем задержку между созданием каждой кометы
        }
    }
}
