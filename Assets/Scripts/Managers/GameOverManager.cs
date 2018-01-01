using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float restartDelay = 5f;

    Animator anim;
    float reastartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

            reastartTimer += Time.deltaTime; 

            if(reastartTimer >= restartDelay)
            {
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene(Application.loadedLevel);
            }
        }
    }
}
