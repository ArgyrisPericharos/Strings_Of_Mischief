using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject UpArrowPrefab, DownArrowPrefab, LeftArrowPrefab, RightArrowPrefab;

    public Vector3 LeftArrowSpawnPoint, UpArrowSpawnPoint, DownArrowSpawnPoint, RightArrowSpawnPoint;

    public float ChoosingTheSpawn;

    public int CrowdSatisfaction = 60;

    public Image CrowdBar;

    public GameObject HandsUpEmoji, IndiferentEMoji;




    //public float LostNotes, HitNotes;

    //public List<TMP_Text> ListOfWordFields;

    //public List<TextToUseTemplate> OrderOfText;

    //public TMP_Text FieldOne, FieldTwo, FieldThree, FieldFour, FieldFive, FieldSix, FieldSeven, FieldEight, FieldNine, FieldTen, FieldEleven, FieldTwelve;

   // public bool OrderWordList;

   // public GameObject IndicatorBall;
    public GameObject AudioObject;

    

    // Start is called before the first frame update
    void Start()
    {
        CrowdSatisfaction = 40;

        /*
        ListOfWordFields.Add(FieldOne);
        ListOfWordFields.Add(FieldTwo);
        ListOfWordFields.Add(FieldThree);
        ListOfWordFields.Add(FieldFour);
        ListOfWordFields.Add(FieldFive);
        ListOfWordFields.Add(FieldSix);
        ListOfWordFields.Add(FieldSeven);
        ListOfWordFields.Add(FieldEight);
        ListOfWordFields.Add(FieldNine);
        ListOfWordFields.Add(FieldTen);
        ListOfWordFields.Add(FieldEleven);
        ListOfWordFields.Add(FieldTwelve);
        */

    }

    // Update is called once per frame
    void Update()
    {
        CrowdSatisfaction = Mathf.Clamp(CrowdSatisfaction, 0, 100);

        CrowdBar.fillAmount = CrowdSatisfaction / 100f;




        if (CrowdSatisfaction >= 60)
        {
            HandsUpEmoji.SetActive(true);
            IndiferentEMoji.SetActive(true);
        }
        else
        {
            HandsUpEmoji.SetActive(false);
            IndiferentEMoji.SetActive(false);
        } 

        /*
        if (OrderOfText.Count <= 0)
        {
            SceneManager.LoadScene("EndScreen");
        }

        if (ListOfWordFields.Count == 0)
        {
            OrderWordList = true;

            if (OrderWordList == true)
            {
                OrderOfText.RemoveAt(0);
                ReOrderList();
            }


        }

        //IndicatorBall.transform.position = new Vector3(ListOfWordFields[0].GetComponentInParent<Transform>().transform.position.x, ListOfWordFields[0].GetComponentInParent<Transform>().transform.position.y + 0.5f, -1);
        IndicatorBall.transform.position = new Vector3(ListOfWordFields[0].GetComponentInParent<Transform>().transform.position.x, ListOfWordFields[0].GetComponentInParent<Transform>().transform.position.y - 0.375f, -1);

        FieldOne.text = OrderOfText[0].TextBubbleOne.ToString();
        FieldTwo.text = OrderOfText[0].TextBubbleTwo.ToString();
        FieldThree.text = OrderOfText[0].TextBubbleThree.ToString();
        FieldFour.text = OrderOfText[0].TextBubbleFour.ToString();
        FieldFive.text = OrderOfText[0].TextBubbleFive.ToString();
        FieldSix.text = OrderOfText[0].TextBubbleSix.ToString();
        FieldSeven.text = OrderOfText[0].TextBubbleSeven.ToString();
        FieldEight.text = OrderOfText[0].TextBubbleEight.ToString();
        FieldNine.text = OrderOfText[0].TextBubbleNine.ToString();
        FieldTen.text = OrderOfText[0].TextBubbleTen.ToString();
        FieldEleven.text = OrderOfText[0].TextBubbleEleven.ToString();
        FieldTwelve.text = OrderOfText[0].TextBubbleTwelve.ToString();


        */

    }

        public void SpawnArrows()
        {
            ChoosingTheSpawn = Random.Range(1, 4);

            if (ChoosingTheSpawn == 1)
            {
                Instantiate(UpArrowPrefab, new Vector3(UpArrowSpawnPoint.x, UpArrowSpawnPoint.y, UpArrowSpawnPoint.z), Quaternion.identity);

            }

            if (ChoosingTheSpawn == 2)
            {
                Instantiate(LeftArrowPrefab, new Vector3(LeftArrowSpawnPoint.x, LeftArrowSpawnPoint.y, LeftArrowSpawnPoint.z), Quaternion.identity);
            }

            if (ChoosingTheSpawn == 3)
            {

                Instantiate(RightArrowPrefab, new Vector3(RightArrowSpawnPoint.x, RightArrowSpawnPoint.y, RightArrowSpawnPoint.z), Quaternion.identity);
            }

            if (ChoosingTheSpawn == 4)
            {
                Instantiate(DownArrowPrefab, new Vector3(DownArrowSpawnPoint.x, DownArrowSpawnPoint.y, DownArrowSpawnPoint.z), Quaternion.identity);
            }
        }

    /*
        public void ReOrderList()
        {
            ListOfWordFields.Add(FieldOne);
            ListOfWordFields.Add(FieldTwo);
            ListOfWordFields.Add(FieldThree);
            ListOfWordFields.Add(FieldFour);
            ListOfWordFields.Add(FieldFive);
            ListOfWordFields.Add(FieldSix);
            ListOfWordFields.Add(FieldSeven);
            ListOfWordFields.Add(FieldEight);
            ListOfWordFields.Add(FieldNine);
            ListOfWordFields.Add(FieldTen);
            ListOfWordFields.Add(FieldEleven);
            ListOfWordFields.Add(FieldTwelve);

            ListOfWordFields[0].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[1].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[2].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[3].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[4].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[5].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[6].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[7].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[8].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[9].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[10].GetComponent<TextMeshProUGUI>().color = Color.black;
            ListOfWordFields[11].GetComponent<TextMeshProUGUI>().color = Color.black;

            OrderWordList = false;
        }
    */

        /* public void TuneStart()
         {
        15.926


             //0.8 secs later
             Instantiate(UpArrowPrefab, new Vector3(UpArrowSpawnPoint.x, UpArrowSpawnPoint.y, UpArrowSpawnPoint.z), Quaternion.identity);
             //1.568 sec later

             //2.261sec later

             //2.9 and then 3.2

             //3.398 and  

             //4.2

             //5.1

             //5.8


             //10,11,12,13

             //6.4, 6.6, 6.8, 7

             //7.69

             //8.58

             //9.2

             //9.9, 10.1, 10.3, 10.5

             //11.1

             //12

             //12.8
         }
        */
    
}
