using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlaveController : MonoBehaviour
{
    public GameObject Aviso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var tag = other.gameObject.tag;
        Debug.Log(tag);

        if (tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "SampleScene")
            {
                SceneManager.LoadScene(sceneName: "Scene2");
            }
            if (scene.name == "Scene2")
            {
                var x = this.transform.position.x;
                var y = this.transform.position.y;
                var avisoGO = Instantiate(Aviso, new Vector2(x, y), Quaternion.identity) as GameObject;
                
                Destroy(this.gameObject);
            }

        }
    }
}
