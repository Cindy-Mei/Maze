using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class check : MonoBehaviour
{
    public Transform myTransform;
    private string code = "0180";
    public InputField Input;
    public string answer;


   public void checkcode()
    {
        answer = Input.text;

        if(answer!=null)
        {

            if (answer == code)
            {
                myTransform.position += Vector3.left * 10;

            }

            else
            {
                Debug.Log("wrong");

            }
                
                
                
        }






    }
}
