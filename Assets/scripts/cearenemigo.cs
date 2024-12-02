using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cearenemigo : MonoBehaviour
{
    public GameObject Prefap;
    public float counter;
    public float limit;
    public float maxvalue;
    public float minvalue;
    public GameManagerControl gameManager;

    // Start is called before the first frame update
    void awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter > limit)
        {
            float position = Random.Range(minvalue, maxvalue);
            GameObject muerte_enemigo = Instantiate(Prefap, new Vector2(position, transform.position.y), transform.rotation);
            muerte_enemigo.GetComponent<muerte_enemigo>().SetGameManager(gameManager);
            counter = 0;

        }
        counter = counter + Time.deltaTime;
    }
}
