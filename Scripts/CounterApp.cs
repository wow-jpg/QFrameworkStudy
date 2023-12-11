using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFramework.Example
{

    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new CounterModel());
        }
    }
}