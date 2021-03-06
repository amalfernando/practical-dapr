using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace CoolStore.WebUI.Host
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetStores
        : IGetStores
    {
        public GetStores(
            global::System.Collections.Generic.IReadOnlyList<global::CoolStore.WebUI.Host.IStoreDto1> stores)
        {
            Stores = stores;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::CoolStore.WebUI.Host.IStoreDto1> Stores { get; }
    }
}
