using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{
    [SerializeField] SpriteRenderer renderer;
    [SerializeField] MeshRenderer meshRenderer1,meshRenderer2;
    [SerializeField] Material material1,material2;
    [SerializeField] Transform tr1, tr2;

    private float timer;
    private float x, y, alpha;

    void Start()
    {
        timer = 0;
        alpha = 1.0f;
        x = renderer.transform.localScale.x;
        y = renderer.transform.localScale.y;
        renderer.transform.localScale = Vector3.one;
        renderer.color = Color.white;
    }    
    void Update()
    {
        timer += Time.deltaTime;
        renderer.transform.localScale = new Vector2(x, y);
        renderer.color = new Color(1, 1, 1, alpha);

        if (timer > .5f)
        {
            x += 0.01f;
            y += 0.01f;
            alpha -= 0.001f;
        }

        if(timer > 2)
        {
            meshRenderer1.material = material1;
            meshRenderer2.material = material1;
        }

        if(timer > 3)
        {
            tr1.Rotate(.1f, .1f, .1f);
            tr2.Rotate(.1f, .1f, .1f);           
        }

        if (timer > 4)
        {
            meshRenderer1.material = material2;
            meshRenderer2.material = material2;
        }

            if (timer > 5)
        {
            SceneManager.LoadScene("game");
        }
    }
}
