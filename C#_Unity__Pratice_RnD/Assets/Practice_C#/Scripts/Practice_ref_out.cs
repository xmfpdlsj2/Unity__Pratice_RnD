using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_ref_out : MonoBehaviour
{


    private void Awake()
    {
        Main();
    }

    private void Main()
    {
        int number = 0;
        ChangeNumger(number);
        Debug.Log($"valueType [{number}]");
        ChangeNumger_ref(ref number);
        Debug.Log($"reference Type [{number}]");
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

    }
    private void ChangeClass_ref(ref Monster monster)
    {

    }
}

public class Monster
{
    public int id;
    public string name;
}
