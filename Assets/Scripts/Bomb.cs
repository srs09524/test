using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public int count;
    public Text scoreText;

    public float speed = .3f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y,
                                         transform.position.z - speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // game object = cube and if it intersects with a gameobject that has the tag 'Coin' assigned to it
        if (gameObject.CompareTag("bomb"))
        {
            // the coin will disappear
            gameObject.SetActive(false);

            // Add one to the score variable 'count' and update ScoreText in the scene

            Score.ScoreCount -= 1;

            // scoreText.GetComponent<Text>().text = " " + count;
        }

    }
}