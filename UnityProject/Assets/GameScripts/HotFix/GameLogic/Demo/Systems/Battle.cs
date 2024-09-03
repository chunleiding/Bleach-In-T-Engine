using System.Collections;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

namespace GameLogic
{
    [Update]
    public class Battle : BaseLogicSys<Battle>
    {
        public override void OnStart()
        {
            base.OnStart();
            Log.Info("Start");
        }
        public override bool OnInit()
        {
            Log.Info("init");
            return base.OnInit();
        }
        public override void OnUpdate()
        {
            base.OnUpdate();
            Log.Info("update");
        }
    }
}
