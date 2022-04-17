using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalCtr2 : MonoBehaviour
{
    public Text lx_P2_Text;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreUI = GameObject.FindWithTag("score1");
        lx_P2_Text  = scoreUI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ball")
        {
            int score_P2 = int.Parse(lx_P2_Text.text);
            score_P2 += 1;
            lx_P2_Text.text = score_P2.ToString();
            Debug.Log("score_P2" + lx_P2_Text);
        }
    }
}
