using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalCtr : MonoBehaviour
{
    private Text m_score_Text;
    private GameObject resetBtn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreUI = null;
        if (this.name == "goalCtrl")
            scoreUI = GameObject.FindWithTag("score1");
        else
            scoreUI = GameObject.FindWithTag("score2");
        m_score_Text = scoreUI.GetComponent<Text>();

        GameObject[] pAllObjects = (GameObject[])Resources.FindObjectsOfTypeAll(typeof(GameObject));
        foreach (GameObject pObject in pAllObjects)
        {
            if (pObject.tag == "resetBtn")
            {
                resetBtn = pObject;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ball")
        {
            int score = int.Parse(m_score_Text.text);
            score += 1;
            m_score_Text.text = score.ToString();
            Debug.Log("score" + m_score_Text.text);
            resetBtn.SetActive(true);
        }
    }
   
}
