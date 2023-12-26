using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// is for creating random battles on map
/// </summary>
public class RandomBattle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(GrassTimer());
        }
    }

    IEnumerator GrassTimer()
    {
        float randomTime = Random.Range(1, 4);
        Debug.Log(randomTime);
        yield return new WaitForSeconds(randomTime);
        SceneManager.LoadScene(1);

    }
}
