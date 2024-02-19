using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathBox : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Iam" + other.gameObject.name);

        if (other.gameObject.tag == "Arrows")
        {
            Destroy(other.gameObject);
            gamemanager.CrowdSatisfaction -= 2;
            //gamemanagerscript.GetComponent<GameManager>().LostNotes += 1;
            //gamemanagerscript.GetComponent<GameManager>().ListOfWordFields[0].GetComponent<TextMeshProUGUI>().color = Color.gray;
            // gamemanagerscript.GetComponent<GameManager>().ListOfWordFields.RemoveAt(0);

        }
    }
  
}
