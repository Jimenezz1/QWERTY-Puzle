﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{


    private Scene scene;
    private int nextSceneToLoad;

    private int count;

    private Rigidbody rb;
    public float speed;



    public float mouseSpeed = 100f;



    public Text winText;


    public float jumpForce = 7f;

    public bool SphereOnGround = true;
   



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        scene = SceneManager.GetActiveScene();

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

        count = 0;

        winText.text = "";

    
        Cursor.lockState = CursorLockMode.Locked;



    }

    



    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if(Input.GetKeyDown(KeyCode.Space) && SphereOnGround)
        {
            rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
            SphereOnGround = false;
        }

       

        
    }

   
    void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Enemy2")
        {

            SceneManager.LoadScene(scene.name);

        } else if (other.gameObject.tag == "Win" || count == 9)
    {
            SceneManager.LoadScene(nextSceneToLoad);
        }
        else if (other.gameObject.tag == "Pickup")
		{
          other.gameObject.SetActive(false);
            count += 1;
        } else if(other.gameObject.tag == "Ganar")
		{
            Destroy(this.gameObject);
            winText.text = "You win!";
		} else if(other.gameObject.tag == "Boost")
        {
            speed = 25f;
          
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            SphereOnGround = true;
        } else if(collision.gameObject.tag == "Grander")
        {
            SphereOnGround = false;
        }
        
    }







}
