using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte1 : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        
                SceneManager.LoadScene(3);
            }
    }

