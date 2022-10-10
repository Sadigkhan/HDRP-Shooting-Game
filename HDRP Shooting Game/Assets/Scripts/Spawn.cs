using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject Mutant;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MutantSpawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator MutantSpawn()
    {
        while (true)
        {
            Instantiate(Mutant, new Vector3(0, 0, Player.transform.position.z + Random.Range(10, 15)), Quaternion.identity);
            yield return new WaitForSeconds(6);
        }
    }
}
