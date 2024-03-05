using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerRespawn : MonoBehaviour
{


    // Update is called once per frame
   private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);


        
       SceneManager.LoadScene("Maze");

    }
}
