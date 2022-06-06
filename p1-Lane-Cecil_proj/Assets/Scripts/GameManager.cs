using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioManager am;

    public void Awake()
    {
        am = GetComponent<AudioManager>();
    }

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoroutine("StartMusic");
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main Scene");
        
    }

    public IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(1f);
        am.Play("Game Music");
    }

    public IEnumerator StopMusic()
    {
        am.Pause("Game Music");
        yield return new WaitForSeconds(0.1f);
    }
}
