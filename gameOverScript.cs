using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameOverScript : MonoBehaviour
{
    public Text pointsText;
    // Start is called before the first frame update
    public void Setup(float score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Time";
    }

    public void restartButton(){
        SceneManager.LoadScene("Game");
    }
        public void exitButton(){
        SceneManager.LoadScene("MainMenu");
    }


}
