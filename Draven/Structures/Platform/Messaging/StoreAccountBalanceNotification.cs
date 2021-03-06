﻿using RtmpSharp.IO;
using System;

namespace Draven.Structures
{
    [Serializable]
    [SerializedName("com.riotgames.platform.messaging.StoreAccountBalanceNotification")]
    class StoreAccountBalanceNotification
    {
        [SerializedName("rp")]
        public Double RP { get; set; }

        [SerializedName("ip")]
        public Double IP { get; set; }
    }
}
