using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalCtr : MonoBehaviour
{
    public Text m_P1_Text;
    public Text m_P2_Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ball")
        {
            int score = int.Parse(m_P1_Text.text);
            score += 1;
            m_P1_Text.text = score.ToString();
            Debug.Log("score" + m_P1_Text.text);
        }
    }
   
}
