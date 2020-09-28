using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_key : MonoBehaviour
{
    public GameObject playerCharacter;
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider playerCharacter){

      uiObject.SetActive(true);
      StartCoroutine("WaitForSec");

    }

    IEnumerator WaitForSec(){
      yield return new WaitForSeconds(5);
    }
}
