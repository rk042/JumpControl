using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace JumpControl.Core
{    
    public class UiManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI scoreText; 
        [SerializeField] TextMeshProUGUI gameoverScoreText;

        private int score=0;

        private void OnEnable()
        {
            PlatfromGenerator.ScoreIncrese+=UpdateScore;
        }

        private void OnDisable()
        {            
            PlatfromGenerator.ScoreIncrese-=UpdateScore;
        }

        public void UpdateScore()
        {
            score++;
            scoreText.text="Score :" +score.ToString("0000");
            gameoverScoreText.text="Score :"+ score;
        }

        public void btn_Retry()
        {
            Time.timeScale=1f;
            SceneManager.LoadScene(1);
        }

        public void btn_Home()
        {
            Time.timeScale=1f;
            SceneManager.LoadScene(0);
        }        
    }
}
