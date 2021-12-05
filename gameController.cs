using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameController : MonoBehaviour
{
    // Start is called before the first frame update
    public gameOverScript gameOverScript;

    public float timeStart = 0;
    int score =0;

    public void gameOver() {
        gameOverScript.Setup(timeStart);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart +=  Time.deltaTime;
    }
}
