﻿using Microsoft.AspNetCore.Components;
using System;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// TableCellConfirmButton 组件
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class TableCellConfirmButton<TItem> : PopConfirmButton where TItem : class, new()
    {
        /// <summary>
        /// 获得/设置 当前行绑定数据
        /// </summary>
        [Parameter] public TItem? Item { get; set; }

        /// <summary>
        /// 获得/设置 按钮点击后的回调方法
        /// </summary>
        [Parameter] public Action<TItem>? OnClickCallback { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            OnBeforeClick = () =>
            {
                if (Item != null) OnClickCallback?.Invoke(Item);
                return true;
            };
        }
    }
}
