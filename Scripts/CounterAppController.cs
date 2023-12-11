using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QFramework.Example
{

    public class CounterAppController : MonoBehaviour,IController
    {
        public Button btnAdd;
        public Button btnSub;

        public Text countText;


        private CounterModel  mModel;
        void Start()
        {
            mModel=this.GetModel<CounterModel>();

            btnAdd.onClick.AddListener(() =>
            {
                //½»»¥Âß¼­
                this.SendCommand<IncreaseCountCommand>();
            });
            btnSub.onClick.AddListener(() =>
            {
                //½»»¥Âß¼­
                this.SendCommand<DecreaseCountCommand>();
                
            });

            //±íÏÖÂß¼­
            this.RegisterEvent<CountChangedEvent>(e =>
            {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void UpdateView()
        {
            countText.text = mModel.Count.ToString();
        }

        void Update()
        {

        }

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }
    }

}