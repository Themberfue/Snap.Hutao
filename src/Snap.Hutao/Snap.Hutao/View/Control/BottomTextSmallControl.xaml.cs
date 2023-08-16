// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace Snap.Hutao.View.Control;

[ContentProperty(Name = nameof(TopContent))]
[DependencyProperty("Text", typeof(string), "")]
[DependencyProperty("TopContent", typeof(UIElement), default!)]
internal sealed partial class BottomTextSmallControl : UserControl
{
    public BottomTextSmallControl()
    {
        InitializeComponent();
    }
}