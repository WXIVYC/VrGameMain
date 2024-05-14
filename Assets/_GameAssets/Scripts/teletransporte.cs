using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teletransporte : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        
                SceneManager.LoadScene(2);
            }
    }

