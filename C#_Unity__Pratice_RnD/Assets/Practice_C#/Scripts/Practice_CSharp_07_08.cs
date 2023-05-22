using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Practice_CSharp_07_08 : MonoBehaviour
{


    private void Awake()
    {
        Main();
    }

    private void Main()
    {
        //RefnOut();

        NullMerge((isNull) =>
        {
            Debug.Log($"Call back is: {isNull}");
        });
    }

    private void NullMerge(Action<bool> callBack)
    {
        callBack?.Invoke(true);

        List<string> list = new List<string>();

        //list[0] ??= "";
    }

    private void RefnOut()
    {
        int number = 0;
        ChangeNumger(number);
        Debug.Log($"valueType [{number}]");
        ChangeNumger_ref(ref number);
        Debug.Log($"reference Type [{number}]");

        Monster dragon = new Monster();
        dragon.id = 100;
        dragon.name = "Agryong";

        ChangeClass(dragon);
        Debug.Log($"junt class: {dragon.id}");
        ChangeClass_ref(ref dragon);
        Debug.Log($"ref class: {dragon.id}");
    }
    private void ChangeNumger(int num)
    {
        num = 250;
    }
    private void ChangeNumger_ref(ref int num)
    {
        num = 250;
    }

    private void ChangeClass(Monster monster)
    {
        monster.id = 200;

        monster = new Monster();
        monster.id = 300;
    }
    private void ChangeClass_ref(ref Monster monster)
    {
        monster.id = 200;

        monster = new Monster();
        monster.id = 300;
    }


    // ¹«½ÃÀÚ _=
    private void DiscardOperator()
    {
        var person = ("John", "Smith");
        var (first, _) = person;

        Debug.Log(first);
        //Debug.Log(_); // error why?
    }
}

public class Monster
{
    public int id;
    public string name;
}
