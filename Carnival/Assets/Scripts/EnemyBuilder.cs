using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBuilder : MonoBehaviour, IBuilder
{
    private GameObject enemy;

    [SerializeField] GameObject enemyTypeOne;
    [SerializeField] GameObject enemyTypeTwo;
    [SerializeField] GameObject enemyTypeThree;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i > -3; i--)
        {
            for (int j = -5; j < 6; j++)
            {
                if (i == 0)
                {
                    enemy = enemyTypeOne;
                }

                else if(i == -1)
                {
                    enemy = enemyTypeTwo;
                }

                else 
                {
                    enemy = enemyTypeThree;
                }

                BuildPartSize(enemy.GetComponent<Enemy>());
                BuildPartPointValue(enemy.GetComponent<Enemy>());
                BuildPartColor(enemy.GetComponent<Enemy>());

                Instantiate(enemy, this.transform);
                enemy.transform.position = new Vector3(j, i, 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildPartSize(Enemy enemy)
    {
        int random = Random.Range(1, 11);
        float size = random / 10.0f;

        enemy.Add(size);
    }

    public void BuildPartPointValue(Enemy enemy)
    {
        int random = Random.Range(25, 101);

        enemy.Add(random);
    }

    public void BuildPartColor(Enemy enemy)
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        enemy.Add(color);
    }
}