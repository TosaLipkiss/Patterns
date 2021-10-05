using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTutorial : MonoBehaviour
{
    delegate void DelegateExample(int a);

    private void Start()
    {
        /*        DelegateExample myDelegate = Bar;
                myDelegate(5);*/

        FooBar(Bar);
    }

    void FooBar(DelegateExample mydelegate)
    {
        mydelegate(4);
    }
    void Foo(int a) //Do something
    {

    }

    void Bar(int a) // Do something too
    {

    }
}
