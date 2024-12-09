using UnityEngine;
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D AlexBody;
    public LogicScript logic;
    public float flapStrength;
    public int lives = 3;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Alex";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            AlexBody.velocity= Vector2.up * flapStrength;
        }
        if((AlexBody.transform.position.y < -13 || AlexBody.transform.position.y > 14) && birdAlive)
        {
            logic.GameOver();
            birdAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(birdAlive)
        {
            logic.GameOver();
            birdAlive = false;
        }
    }
}
