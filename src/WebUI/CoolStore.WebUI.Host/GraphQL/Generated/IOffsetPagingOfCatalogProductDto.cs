using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace CoolStore.WebUI.Host
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IOffsetPagingOfCatalogProductDto
    {
        global::System.Collections.Generic.IReadOnlyList<global::CoolStore.WebUI.Host.ICatalogProductDto> Edges { get; }

        int TotalCount { get; }
    }
}
