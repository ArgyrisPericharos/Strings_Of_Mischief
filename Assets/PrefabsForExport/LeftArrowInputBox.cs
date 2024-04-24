using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WiimoteApi;

public class LeftArrowInputBox : MonoBehaviour
{
    public GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Iam" + other.gameObject.name);

        if (other.gameObject.tag == "StrumTap")
        {
            if (this.gameObject.GetComponent<WiimoteDemo>().StrumIsDown == true || this.gameObject.GetComponent<WiimoteDemo>().StrumIsUp == true)
            {
                Debug.Log("Hit");
                Destroy(other.gameObject);
                gamemanager.CrowdSatisfaction += 5;
                //gamemanagerscript.GetComponent<GameManager>().HitNotes += 1;
               
            }
        

        }


        if (other.gameObject.tag == "TapNoStrum")
        {
            Destroy(other.gameObject);
        }



        //firsttap with strum (like it was before) and then hold (you have tho hold the not button, but if you strum or let go thats it, u missed it) this would be done with different smaller objects that would all be part of a bigger chain that i will be deleting bit by bit
    }

}
