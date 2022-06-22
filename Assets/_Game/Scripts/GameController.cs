using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject splash;

    [HideInInspector] 
    public Color32 apple_gColor = new Color32(108, 136, 9, 255), 
    apple_rColor = new Color32(138, 17, 9, 255), 
    coconutColor = new Color32(98, 62,38,255), 
    orangeColor = new Color32(255,128,12,255), 
    pineapleColor = new Color32(181, 106,21,255), 
    pearColor = new Color32(168, 179, 0, 255), 
    bananaColor = new Color32(234, 173,11,255), 
    honeydewMelonColor = new Color32(240, 191, 0, 255), 
    kiwiColor = new Color32(116, 88, 26, 255), 
    lemonColor = new Color32(235, 205, 0, 255), 
    limeColor = new Color32(62, 115, 1, 255), 
    pepper_gColor = new Color32(49, 73, 1, 255), 
    pepper_pointedColor = new Color32(151, 26, 3, 255), 
    pepper_rColor = new Color32(135, 18, 0, 255), 
    pepper_yColor = new Color32(240, 167, 0 ,255), 
    plumColor = new Color32(117, 16, 33, 255), 
    pomegranateColor = new Color32(188, 32, 75, 255), 
    strawberryColor = new Color32(167, 0 ,21, 255), 
    tomatoColor = new Color32(142, 33, 0, 255), 
    watermelonColor = new Color32(150, 173, 49, 255),
    uiRedColor = new Color32(255, 0, 0, 255);

    private UIController uIController;

    [HideInInspector] public int score, fruitCount;
    [SerializeField] private GameObject fruitSpawner, blade, destroyer;
    // Start is called before the first frame update
    void Start()
    {
        uIController = FindObjectOfType<UIController>();
        score = 0;
        fruitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        uIController.txtScore.text = "Score: " + score.ToString();
    }

    public void UpdateScore(int points){
        score += points;
        uIController.txtScore.text =  "Score: " + score.ToString();
    }

    public void GameOver(){
        fruitSpawner.gameObject.SetActive(false);
        destroyer.gameObject.SetActive(false);
        blade.gameObject.SetActive(false);
    }
}
