using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuilder
{
    void BuildPartSize(Enemy enemy);

    void BuildPartPointValue(Enemy enemy);

    void BuildPartColor(Enemy enemy);
}
