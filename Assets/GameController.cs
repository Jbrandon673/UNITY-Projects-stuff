using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

    public static GameController intstance;

    public bool inPlay = false;
    bool gameover = false;

    public int scoreOne;
    public int scoreTwo;
    [SerializeField] int scoreToWin;

    public Text textOne;
    public Text textTwo;

    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Text winnerText;

    public object gameOverpanel { get; private set; }

    private void OnEnable()
    {
        intstance = this;
    }
    
    // Update is called once per frame
    void Update() {
        {
            if (inPlay == false && gameover != true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    inPlay = true;
                }
            {

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    SceneManager.LoadScene(0);
                }
                Winner();
            }
        void Winner() 
        {
            if (!gameover)
            {
                if(scoreOne >= scoreToWin)
                {
                     gameover = true;
                     winnerText.text = "Player 1 Win";
                            //This is for unity
                            GameObject.Find("gameOverpanel").SetActive(true);

                }
                if(scoreTwo >= scoreToWin)
                {
                     gameover = true;
                     winnerText.text = "Player 2 Win";
                            //This is for unity
                            GameObject.Find("gameOverpanel").SetActive(true);

                }
        
                }
                    
             }
                
            }

        }
    }
}


            




