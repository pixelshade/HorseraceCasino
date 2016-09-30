using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HorsePrefabScript : MonoBehaviour {
    [SerializeField]
    private Text horseNameText;

    [SerializeField]
    private SpriteRenderer horseSprite;

    private Animator animator;
    private Horse horse;


    private bool moving;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (moving)
        {
            horse.GetPos();
        }
    }

    public void SetHorse(Horse horse)
    {
        this.horse = horse;
        horseNameText.text = horse.Name;
        horseSprite.sprite = Resources.Load(horse.Sprite) as Sprite;
    }

    public void StartRunning()
    {
        moving = true;
        animator.SetTrigger("running");
    }

    public void StopRunning()
    {
        moving = false;
        animator.SetTrigger("normal");
    }
}
