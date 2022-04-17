using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICtr : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject startUI;
    public GameObject playerUI;
    // public GameObject player;
    // public GameObject ball;
    // public GameObject scene;
    public GameObject Camera_UI;
    public GameObject resetScore;
    public Text m_score1_Text;
    public Text m_score2_Text;
    //private Transform playerInitTrans;
    //private Transform ballInitTrans;
    //private Transform camInitTrans;
    //bool resetState = false;
    void Start()
    {
       //playerInitTrans = player.transform;
       //ballInitTrans = ball.transform;
       //camInitTrans = cam.transform;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void startGame()
    {
        show(false);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void exit()
    {
        SceneManager.UnloadSceneAsync("scene1");
        m_score1_Text.text = "0";
        m_score2_Text.text = "0";
        show(true);
        //分数重置
    }

    public void reset()
    {
        //resetState = true;
        ////球和人的位置重置
        //player.SetActive(false);
        //ball.SetActive(false);
        //player.transform.position = playerInitTrans.position;
        //player.transform.rotation = playerInitTrans.rotation; 
        //ball.transform.rotation = ballInitTrans.rotation;
        ////摄像机重置
        //cam.transform.position = camInitTrans.position;
        //cam.transform.rotation = camInitTrans.rotation;   
        SceneManager.UnloadSceneAsync("scene1");
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        resetScore.SetActive(false);
        
    }

    public void show(bool isExit)
    {
        startUI.SetActive(isExit);
        playerUI.SetActive(!isExit);
        //Camera_UI.SetActive(isExit);
        // player.SetActive(!isExit);
        // scene.SetActive(!isExit);
        // easyTouch.SetActive(!isExit);
        //ball.SetActive(!isExit);
    }
}
