using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManagerScript : MonoBehaviour
{

    public int TimerState;

    public float TimeGoneBy;

    private bool One, Two, Three, Four, Five, Six, Seven, Eighth, Nineth, Tenth, Eleventh, Twelveth, Thirteenth, Fouteenth, Fifteenth, Sixteenth, Seventeenth, Eighteenth, Nineteenth, twentieth, twentyfirst, twentysecond, tewntythird, twentyfourth, twentyfifth;
    // Start is called before the first frame update
    void Start()
    {

        TimerState = 0;
        TimeGoneBy = 16.926f;


        One = true;
        Two = true;
        Three = true;
        Four = true;
        Five = true;
        Six = true;
        Seven = true;
        Eighth = true;
        Nineth = true;
        Tenth = true;
        Eleventh = true;
        Twelveth = true;
        Thirteenth = true;
        Fouteenth = true;
        Fifteenth = true;
        Sixteenth = true;
        Seventeenth = true;
        Eighteenth = true;
        Nineteenth = true;
        twentieth = true;
        twentyfirst = true;
        twentysecond = true;
        tewntythird = true;
        twentyfourth = true;
        twentyfifth = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerState == 0)
        {
            TimeGoneBy -= Time.deltaTime;


            if (TimeGoneBy <= 16.866 && One == true)
            {
                //1st at  00
                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);
                One = false;
            }

            if (TimeGoneBy <= 16.126f && Two == true)
            {
                //2nd beat at 0.8 secs 

                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);
                Two = false;

            }

            if (TimeGoneBy <= 15.926f)
            {
                this.gameObject.GetComponent<GameManager>().AudioObject.SetActive(true);
            }

            if (TimeGoneBy <= 15.358f && Three == true)
            {
                //3rd beat at 1.568 sec

                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);
                Three = false;
            }

            if (TimeGoneBy <= 14.665f && Four == true)
            {
                //4thbeat at 2.261sec


                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);
                Four = false;
            }

            if (TimeGoneBy <= 14.226f && Five == true)
            {
                //5th beat at 2.7sec


                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);
                Five = false;
            }

            if (TimeGoneBy <= 14.026f && Six == true)
            {
                //6thbeat at 2.9

                Instantiate(this.gameObject.GetComponent<GameManager>().UpArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.z), Quaternion.identity);
                Six = false;

            }


            if (TimeGoneBy <= 13.726f && Seven == true)
            {
                //7thbeat at 3.2

                Instantiate(this.gameObject.GetComponent<GameManager>().UpArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.z), Quaternion.identity);

                Seven = false;
            }

            if (TimeGoneBy <= 13.526f && Eighth == true)
            {
                //8thbeat at 3.4
                Instantiate(this.gameObject.GetComponent<GameManager>().LeftArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().LeftArrowSpawnPoint.z), Quaternion.identity);

                Eighth = false;

            }

            if (TimeGoneBy <= 12.726f && Nineth == true)
            {
                //9thbeat at 4.2
                Instantiate(this.gameObject.GetComponent<GameManager>().UpArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.z), Quaternion.identity);

                Nineth = false;
            }

            if (TimeGoneBy <= 11.826f && Tenth == true)
            {
                //10thbeat at 5.1
                Instantiate(this.gameObject.GetComponent<GameManager>().UpArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.z), Quaternion.identity);

                Tenth = false;
            }

            if (TimeGoneBy <= 11.126f && Eleventh == true)
            {
                //11thbeat at 5.8
                Instantiate(this.gameObject.GetComponent<GameManager>().UpArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().UpArrowSpawnPoint.z), Quaternion.identity);

                Eleventh = false;
            }

            if (TimeGoneBy <= 10.526f && Twelveth == true)
            {
                //12thbeat at 6.4
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                Twelveth = false;
            }

            if (TimeGoneBy <= 10.326f && Thirteenth == true)
            {
                //13thbeat at 6.6
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                Thirteenth = false;
            }

            if (TimeGoneBy <= 10.126f && Fouteenth == true)
            {
                //14thbeat at 6.8
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                Fouteenth = false;
            }

            if (TimeGoneBy <= 9.926f && Fifteenth == true)
            {
                //15thbeat at 7
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                Fifteenth = false;
            }

            if (TimeGoneBy <= 9.236f && Sixteenth == true)
            {
                //16thbeat at 7.69
                Instantiate(this.gameObject.GetComponent<GameManager>().RightArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.z), Quaternion.identity);

                Sixteenth = false;
            }

            if (TimeGoneBy <= 8.346f && Seventeenth == true)
            {
                //17thbeat at 8.58
                Instantiate(this.gameObject.GetComponent<GameManager>().RightArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.z), Quaternion.identity);

                Seventeenth = false;
            }

            if (TimeGoneBy <= 7.726f && Eighteenth == true)
            {
                //18thbeat at 9.2
                Instantiate(this.gameObject.GetComponent<GameManager>().RightArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().RightArrowSpawnPoint.z), Quaternion.identity);

                Eighteenth = false;
            }

            if (TimeGoneBy <= 7.026 && Nineteenth == true)
            {
                //19thbeat at 9.9
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                Nineteenth = false;
            }

            if (TimeGoneBy <= 6.826 && twentieth == true)
            {
                //20thbeat at 10.1
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                twentieth = false;
            }

            if (TimeGoneBy <= 6.626 && twentyfirst == true)
            {
                //21stbeat at 10.3
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                twentyfirst = false;
            }

            if (TimeGoneBy <= 6.426 && twentysecond == true)
            {
                //22ndbeat at 10.5
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);
                twentysecond = false;
            }

            if (TimeGoneBy <= 5.826 && tewntythird == true)
            {
                //23rdbeat at 11.1
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                tewntythird = false;
            }

            if (TimeGoneBy <= 4.926 && twentyfourth == true)
            {
                //24ththbeat at 12
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);
                twentyfourth = false;

            }

            if (TimeGoneBy <= 4.126 && twentyfifth == true)
            {
                //25thbeat at 12.8
                Instantiate(this.gameObject.GetComponent<GameManager>().DownArrowPrefab, new Vector3(this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.x, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.y, this.gameObject.GetComponent<GameManager>().DownArrowSpawnPoint.z), Quaternion.identity);

                twentyfifth = false;
            }

        }


        if (TimeGoneBy <= 1)
        {
            TimerState = 1;
        }

        if (TimerState == 1)
        {
            //SpawnArrows();
            One = true;
            Two = true;
            Three = true;
            Four = true;
            Five = true;
            Six = true;
            Seven = true;
            Eighth = true;
            Nineth = true;
            Tenth = true;
            Eleventh = true;
            Twelveth = true;
            Thirteenth = true;
            Fouteenth = true;
            Fifteenth = true;
            Sixteenth = true;
            Seventeenth = true;
            Eighteenth = true;
            Nineteenth = true;
            twentieth = true;
            twentyfirst = true;
            twentysecond = true;
            tewntythird = true;
            twentyfourth = true;
            twentyfifth = true;

            TimeGoneBy = 16.926f;
            TimerState = 0;
        }
    }
}
