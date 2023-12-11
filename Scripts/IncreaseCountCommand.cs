using QFramework;
using QFramework.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCountCommand : AbstractCommand
{
    
    protected override void OnExecute()
    {
        this.GetModel<CounterModel>().Count++;
        this.SendEvent<CountChangedEvent>();
    }

}
