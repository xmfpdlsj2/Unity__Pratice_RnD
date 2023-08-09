using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using DG.Tweening;
using System.Runtime.InteropServices;

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

        SystemaRange();
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


    // ������ _=
    private void DiscardOperator()
    {
        var person = ("John", "Smith");
        var (first, _) = person;

        Debug.Log(first);
        //Debug.Log(_); // error why?
    }

    // System.Range
    private void SystemaRange()
    {
        int[] table = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int flexibleNum = UnityEngine.Random.Range(0, table.Length);

        var table2 = table[..flexibleNum];
        for (int i = 0; i < table2.Length; i++)
        {
            Debug.Log($"table2: [{table2[i]}]");
        }

        var table3 = table[2..^3];
        for (int i = 0; i < table3.Length; i++)
        {
            Debug.Log($"table3: [{table3[i]}]");
        }
    }

    // DoTween ���� �������߰� ����
    private void Dootween()
    {
        var dgSequence = DOTween.Sequence();
        
        //DOTween.Append();
        //DOTween.AppendCallback();
        //DOTween.AppendInterval();
        //DOTween.Insert();
        //DOTween.InsertCallback();
        //DOTween.Join();
        //DOTween.Prepend();
        //DOTween.PrependCallback();
        //DOTween.PrependInterval();

        //DOTween.OnUpdate();
        //DOTween.OnStart();

        // �������� Ŀ�������ε� Ʈ���� ��������ϱ⵵�ߴ�. ��ӹ޾Ƽ� ��밡���ѵ� 
        // DoJump �� �� �״�� ���� �ϴ� ���Ѱ� �ƴϾ���. �������� �����̴°� �翬.. �뵵�� ��ü? 
        // �����ϴ� ���ϴ°� ������ �� ��������� DoPath�� ����ؾ��Ѵ�. Gpt�� �˷��� ����. 

        // �ִϸ����Ϳ��� Ŭ���� ��Ʈ�׷��� ��ܿ� ��Ŭ������ ��ũ��Ʈ �̺�Ʈ�� ������ �ִ�. �̰Ͱ� 
        // ��Ʈ���� ���踦 ����غ����Ѵ�. 
    }

    // is or and etc 
    // �߰��� from �� �⺻�ΰǰ�?
    private void IsOrAndETC()
    {
        string ascii = "ASCII";
        var ret = (ascii == "ASCII" || ascii == "BSCII");
        ret = ascii is "ASCII" or "BSCII";

    }

    // &= ������
    private bool GetBool()
    {
        bool answer = false;
        int one = 1;
        string some = "A";
        answer &= one == 1;
        answer &=  some != "B";
        // .... ���� ������ �ܿ� � ������ ������ ���� ������ �ʿ䰡 �ְڴ�.
        return answer;
    }

    //Datetime and UTC and Tics
    private void DateTimePractice()
    {
        // DateTime class�� ���� ����°��̾���?
    }

    // ���̽㵵 ������.... �׽�Ʈ���������. �Ф� 
    private void Python()
    {
        // �⺻ ������, �Լ��� def ��� ����, ����Ȳ������� ������ ������ �����Ǵµ�
        // �Լ� �ȿ� �Լ��� ��ü?? 
    }

    // params
    // ������Ʈ Ÿ������ �ְ� �޴°Ŷ� �Ķ� �̶�� Ÿ���� ����?? 
    private void ParamsPractice(object p)
    {
        // c++ �� ... ���� ���ε�.  ã�ƺ���.
        // params �Ű������� �Ķ����� �޴°Ͱ� ������Ʈ�� ����
    }

    //linq �����ؼ��� �ڷᱸ��ó�� ���� �˾Ƶ� �ʿ䰡 �ִ�.
    private void LinqPractice()
    {
        // ��ť �߰����� 
        // linq .Where() -> ���ǽ��� ���ٽ����� ������ �ְ� ���ǿ� ���� iEnumerator �÷����� ��ȯ���ִ� �Լ�. 
    }

    // �̱������� Ŭ������ static ��ü�� ���鶧 �ش� Ŭ������ ��� ������ �������� �Ҵ��ϴ� ������ 
    // getter�� �޴°Ŷ� �׳� ���� �����ڷ� �Ҵ��ϴ°Ŷ� ���̰� �ֳ�? 
    public string key = GetStringByKey();
    public string key2 => GetStringByKey();
    private static string GetStringByKey()
    {
        // ȸ�翡�� ����� �̽��� ���� �����ڷ� ������ �Ҵ��ϴ� �������� ���� ������ ���� �ش� NULL ���ܰ� ��... 
        // 2���� �Ǵ����� �ѹ� Ȯ���غ����ؾߵ�. 
        // �̰� �����غ��� �翬�Ѱ��� Ŭ���� ��ü�����鶧 ���ڴ� ������ �ش��Լ������� ���� ���� �ο��ؾ��ϴϱ� Awake���� Ÿ�̹� �̽��� ����������
        // ���ڴ� getteró�� �����Լ��� ȣ���ϴ� ���±⶧���� Ÿ�̹� �̽��� ������ ����.
        return "Nice";
    }

    // C#9.0 ���ϸ�Ī �� �����غ���

    // ��ӱ������� where 
    // ��ӹ����� ��� �Ű�����, ���׸� Ÿ���� where �� Ư�� �� �� �ִ�. 
}

public class Monster
{
    public int id;
    public string name;
}
