using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Trap : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {

       
           // Destroy(other.gameObject);
        
        
        SceneManager.LoadScene("Maze");

    }
}
