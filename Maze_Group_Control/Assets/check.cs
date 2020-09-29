using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class check : MonoBehaviour
{

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
                //door code here

            }

            else
            {
                Debug.Log("wrong");

            }
                
                
                
        }






    }
}
