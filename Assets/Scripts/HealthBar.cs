using UnityEngine;

public class HealthBar : MonoBehaviour
{

    //public GameObject healthBar;
    //private float xPosition;
    //public float moveAmount = 1f;

    private void Start()
    {
        //xPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveHealthBar()
    {
        transform.localScale += new Vector3(-.1f, 0, 0);
        //xPosition = xPosition + moveAmount;
        //transform.position = new Vector2(xPosition, transform.position.y);
    }
}
