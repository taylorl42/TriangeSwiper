using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class spawnScript : MonoBehaviour {

    public UIManager ui;
    public GameObject obstacleSquare;
    public GameObject obstacleFastSquare;
    public GameObject obstacleCircle;
    public int level;
    public int squareSpeed;
    public int circleSpeed;

    private float waitTimeCircle;
    private float waitTime;
    private bool playing;
    private bool inRoutine;
    private int routineNumber;
    
    

    // Use this for initialization
    void Start () {

        circleSpeed = 8;
        squareSpeed = 8;
        playing = false;
        inRoutine = false;
        level = PlayerPrefs.GetInt("Level");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& playing == false)
        {
            SceneManager.LoadScene("LevelSelection");
        }

        //Tap to start the game
        if (playing == false && GameObject.FindWithTag("Obstacle") == null)
        {
            
            foreach (Touch touch in Input.touches)
            {
                if (touch.fingerId == 0)
                {
                    playing = true;
                    ui.Restart();
                    level = PlayerPrefs.GetInt("Level");
                    ui.RemoveStartText();
                    ui.tutorialText.text = "";
                }
            }
        }

        if(PlayerPrefs.GetInt("Level") == 1)
        {
            if (ui.score > 0)
                squareSpeed = 8;
            if (ui.score > 10)
                squareSpeed = 9;
            if (ui.score > 20)
                squareSpeed = 10;
            if (ui.score > 30)
                level = 2;
        }

        if (PlayerPrefs.GetInt("Level") == 2)
        {
            if (ui.score > 0)
                squareSpeed = 8;
            if (ui.score > 10)
                squareSpeed = 9;
            if (ui.score > 20)
                squareSpeed = 10;
            if (ui.score > 30)
                level = 3;
        }
        if (PlayerPrefs.GetInt("Level") == 3)
        {
            squareSpeed = 10;
        }
        if (PlayerPrefs.GetInt("Level") == 6)
        {
            squareSpeed = 12;
            circleSpeed = 14;
            waitTimeCircle = 1;
        }

        if (PlayerPrefs.GetInt("Level") == 4 || PlayerPrefs.GetInt("Level") == 5)
        {
            if (ui.score > 0)
            {
                circleSpeed = 8;
                waitTimeCircle = 1.1f;
            }
            if (ui.score > 10)
            {
                circleSpeed = 9;
                waitTimeCircle = 1;
            }
            if (ui.score > 20)
            {
                circleSpeed = 10;
                waitTimeCircle = 0.9f;
            }
            if (ui.score > 30) {
                circleSpeed = 14;
                waitTimeCircle = 0.7f;
            }
        }


        if (playing == true)
        {
            ui.IncrementScore();
        }

        if (playing == true && inRoutine == false && ui.score > 1)
        {
            PickRoutine();
        }
    }

    public void SetPlaying(bool toSet)
    {
        playing = toSet;
    }

    void PickRoutine()
    {
        waitTime = 0.5f;
        int routine;

        if (level == 1)
        {
            routine = 1;
            PickCoroutine(routine);
        }
            
        if (level == 2)
        {
            routine = UnityEngine.Random.Range(1,3);
            PickCoroutine(routine);
        }
        if (level == 3)
        {
            routine = UnityEngine.Random.Range(2, 4);
            PickCoroutine(routine);
        }
        if (level == 4)
        {
            routine = UnityEngine.Random.Range(3, 5);
            PickCoroutine(routine);
        }
        if (level == 5)
        {
            routine = UnityEngine.Random.Range(4, 6);
            PickCoroutine(routine);
        }
        if (level == 6)
        {
            routine = UnityEngine.Random.Range(1, 6);
            PickCoroutine(routine);
        }
    }
        void PickCoroutine(int routine)
    {
        if (routine == 1) //single squares
            routineNumber = UnityEngine.Random.Range(1, 6);
        if (routine == 2) //double squares
            routineNumber = UnityEngine.Random.Range(6, 11);
        if (routine == 3)//fast squares
            routineNumber = UnityEngine.Random.Range(11, 19);
        if (routine == 4)//circles
            routineNumber = UnityEngine.Random.Range(19, 22);
        if (routine == 5)//double circles
            routineNumber = UnityEngine.Random.Range(22, 25);
        if (routine == 6)//all
            routineNumber = UnityEngine.Random.Range(1, 25);
            

        switch (routineNumber)
        {
            case 1:
                inRoutine = true;
                StartCoroutine(Routine1());
                break;
            case 2:
                inRoutine = true;
                StartCoroutine(Routine2());
                break;
            case 3:
                inRoutine = true;
                StartCoroutine(Routine3());
                break;
            case 4:
                inRoutine = true;
                StartCoroutine(Routine4());
                break;
            case 5:
                inRoutine = true;
                StartCoroutine(Routine5());
                break;
            case 6:
                inRoutine = true;
                StartCoroutine(Routine6());
                break;
            case 7:
                inRoutine = true;
                StartCoroutine(Routine7());
                break;
            case 8:
                inRoutine = true;
                StartCoroutine(Routine8());
                break;
            case 9:
                inRoutine = true;
                StartCoroutine(Routine9());
                break;
                
            case 10:
                inRoutine = true;
                StartCoroutine(Routine10());
                break;
                
            case 11:
                inRoutine = true;
                StartCoroutine(Routine11());
                break;
            case 12:
                inRoutine = true;
                StartCoroutine(Routine12());
                break;
            case 13:
                inRoutine = true;
                StartCoroutine(Routine13());
                break;
            case 14:
                inRoutine = true;
                StartCoroutine(Routine14());
                break;

            case 15:
                inRoutine = true;
                StartCoroutine(Routine15());
                break;
            case 16:
                inRoutine = true;
                StartCoroutine(Routine16());
                break;
            case 17:
                inRoutine = true;
                StartCoroutine(Routine17());
                break;
            case 18:
                inRoutine = true;
                StartCoroutine(Routine18());
                break;
            case 19:
                inRoutine = true;
                StartCoroutine(Routine19());
                break;
            case 20:
                inRoutine = true;
                StartCoroutine(Routine20());
                break;
            case 21:
                inRoutine = true;
                StartCoroutine(Routine21());
                break;
            case 22:
                inRoutine = true;
                StartCoroutine(Routine22());
                break;
            case 23:
                inRoutine = true;
                StartCoroutine(Routine23());
                break;
            case 24:
                inRoutine = true;
                StartCoroutine(Routine24());
                break;
        }
    }

 

    //single squares start
    IEnumerator Routine1()
    {
        SpawnSquare1();
        yield return new WaitForSeconds(waitTime);
        inRoutine = false;
    }
    IEnumerator Routine2()
    {
        SpawnSquare2();
        yield return new WaitForSeconds(waitTime);
        inRoutine = false;
    }
    IEnumerator Routine3()
    {
        SpawnSquare3();
        yield return new WaitForSeconds(waitTime);
        inRoutine = false;
    }
    IEnumerator Routine4()
    {
        SpawnSquare1();
        yield return new WaitForSeconds(waitTime);
        SpawnSquare2();
        yield return new WaitForSeconds(waitTime);
        SpawnSquare3();
        yield return new WaitForSeconds(waitTime);
        inRoutine = false;
    }
    IEnumerator Routine5()
    {
        SpawnSquare3();
        yield return new WaitForSeconds(waitTime);
        SpawnSquare2();
        yield return new WaitForSeconds(waitTime);
        SpawnSquare1();
        yield return new WaitForSeconds(waitTime);
        inRoutine = false;
    }
    //single squares end

    //double squares start
    IEnumerator Routine6()
    {
        SpawnSquare2();
        SpawnSquare3();
        yield return new WaitForSeconds(0.8f);
        inRoutine = false;
    }
    IEnumerator Routine7()
    {
        SpawnSquare1();
        SpawnSquare2();
        yield return new WaitForSeconds(0.8f);
        inRoutine = false;
    }
    IEnumerator Routine8()
    {
        SpawnSquare1();
        SpawnSquare3();
        yield return new WaitForSeconds(0.8f);
        inRoutine = false;
    }
    IEnumerator Routine9()
    {
        SpawnSquare1();
        SpawnSquare2();
        yield return new WaitForSeconds(0.8f);
        SpawnSquare2();
        SpawnSquare3();
        yield return new WaitForSeconds(0.8f);
        SpawnSquare1();
        SpawnSquare2();
        yield return new WaitForSeconds(0.8f);
        inRoutine = false;
    }

    IEnumerator Routine10()
    {
        SpawnSquare1();
        SpawnSquare3();
        yield return new WaitForSeconds(0.4f);
        SpawnSquare2();
        yield return new WaitForSeconds(0.4f);
        SpawnSquare1();
        SpawnSquare3();
        yield return new WaitForSeconds(0.8f);
        inRoutine = false;
    }
    //double squares end

    //fast squares start
    IEnumerator Routine11()
    {
        
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }

    IEnumerator Routine12()
    {
        
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }

    IEnumerator Routine13()
    {
        
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }
    IEnumerator Routine14()
    {
        SpawnFastSquare1();
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }
    IEnumerator Routine15()
    {

        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }

    IEnumerator Routine16()
    {

        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }
    IEnumerator Routine17()
    {
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.3f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }
    IEnumerator Routine18()
    {
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare3();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.3f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare1();
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.2f);
        SpawnFastSquare2();
        yield return new WaitForSeconds(0.6f);
        inRoutine = false;
    }
    //fast squares end

    //circles start
    IEnumerator Routine19()
    {
        SpawnCircle1();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }
    IEnumerator Routine20()
    {
        SpawnCircle2();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }
    IEnumerator Routine21()
    {
        SpawnCircle3();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }
    //circles end
    //double circles start
    IEnumerator Routine22()
    {
        SpawnCircle1();
        SpawnCircle2();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }
    IEnumerator Routine23()
    {
        SpawnCircle2();
        SpawnCircle3();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }
    IEnumerator Routine24()
    {
        SpawnCircle1();
        SpawnCircle3();
        yield return new WaitForSeconds(waitTimeCircle);
        inRoutine = false;
    }

    //double circles end

    //spawn to left
    void SpawnSquare1()
    {
        GameObject squareClone = Instantiate(obstacleSquare, new Vector3(-1.5f, 6, 0), Quaternion.identity);
        squareClone.GetComponent<squareScript>().SetMoveSpeed(squareSpeed);
    }
    //spawn to middle
    void SpawnSquare2()
    {
        GameObject squareClone = Instantiate(obstacleSquare, new Vector3(0, 6, 0), Quaternion.identity);
        squareClone.GetComponent<squareScript>().SetMoveSpeed(squareSpeed);
    }
    //spawn to right
    void SpawnSquare3()
    {
        GameObject squareClone = Instantiate(obstacleSquare, new Vector3(1.5f, 6, 0), Quaternion.identity);
        squareClone.GetComponent<squareScript>().SetMoveSpeed(squareSpeed);
    }

    void SpawnFastSquare1()
    {
        Instantiate(obstacleFastSquare, new Vector3(-1.5f, 6, 0), Quaternion.identity);
    }
    //spawn to middle
    void SpawnFastSquare2()
    {
        Instantiate(obstacleFastSquare, new Vector3(0, 6, 0), Quaternion.identity);
    }
    //spawn to right
    void SpawnFastSquare3()
    {
        Instantiate(obstacleFastSquare, new Vector3(1.5f, 6, 0), Quaternion.identity);
    }

    void SpawnCircle1()
    {
        GameObject circleClone = Instantiate(obstacleCircle, new Vector3(-1.5f, 6, 0), Quaternion.identity);
        circleClone.GetComponent<ballScript>().hitBoundary = (true);
        circleClone.GetComponent<ballScript>().SetMoveSpeed(circleSpeed);
    }
    //spawn to middle
    void SpawnCircle2()
    {
        GameObject circleClone = Instantiate(obstacleCircle, new Vector3(0, 6, 0), Quaternion.identity);
        circleClone.GetComponent<ballScript>().hitBoundary = (UnityEngine.Random.value > 0.5f);
        circleClone.GetComponent<ballScript>().SetMoveSpeed(circleSpeed);
    }
    //spawn to right
    void SpawnCircle3()
    {
        GameObject circleClone = Instantiate(obstacleCircle, new Vector3(1.5f, 6, 0), Quaternion.identity);
        circleClone.GetComponent<ballScript>().hitBoundary = (false);
        circleClone.GetComponent<ballScript>().SetMoveSpeed(circleSpeed);
    }
}