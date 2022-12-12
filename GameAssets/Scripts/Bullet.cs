using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Bullet : MonoBehaviour
{

    public Vector3 targetVector;

    [SerializeField] int speed = 10;
    [SerializeField] float lifeTime = 3f;
   
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    // Update is called once per frame
    void Update()
    {
        //The bullet needs to move on the direction the player is moving.
        transform.Translate(targetVector * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Meteor")
        { // works
            Destroy(other.gameObject);
            ScoreKeeper.instance.IncreaseScore();
        }
    }

}
