using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SplitBalls : MonoBehaviour
{

    [SerializeField] private LayerMask floor;
    [SerializeField] private GameObject ballPrefab;

    private GameObject ballManager;

    // Start is called before the first frame update
    void Start()
    {
        ballManager = FindAnyObjectByType<BallManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == floor.value)
        {

            

            if (gameObject.transform.localScale.x > 20 * 0.7f)
            {

                GameObject temp = Instantiate(ballPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity, ballManager.transform);
                temp.GetComponent<Rigidbody2D>().velocity = new Vector3(gameObject.GetComponent<Rigidbody2D>().velocity.x + 20, 100f, 0f);
                temp.transform.localScale = new Vector3(gameObject.transform.localScale.x *0.8f, gameObject.transform.localScale.y *0.8f, 1f);

         
                temp = Instantiate(ballPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity, ballManager.transform);
                temp.GetComponent<Rigidbody2D>().velocity = new Vector3(gameObject.GetComponent<Rigidbody2D>().velocity.x - 20, 100f, 0f);
                temp.transform.localScale = new Vector3(gameObject.transform.localScale.x *0.8f, gameObject.transform.localScale.y *0.8f, 1f);
            }

            Destroy(gameObject);
        }
    }
}
