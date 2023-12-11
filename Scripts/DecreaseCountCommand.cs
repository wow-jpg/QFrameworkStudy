using QFramework;
using QFramework.Example;
using UnityEngine;

public class DecreaseCountCommand : AbstractCommand
{
    protected override void OnExecute()
    {
        this.GetModel<CounterModel>().Count--;
        this.SendEvent<CountChangedEvent>();
    }
}

