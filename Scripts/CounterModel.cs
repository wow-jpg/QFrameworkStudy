using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace QFramework.Example
{



    public class CounterModel : AbstractModel
    {
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }


            set
            {
                if (count != value)
                {
                    count = value;
                    storage.SaveInt(nameof(count), value);
                }
            }
        }

        private Storage storage;
        protected override void OnInit()
        {
            storage=this.GetUtility<Storage>();
            count = storage.LoadInt(nameof(count), count);

        }


    }
}