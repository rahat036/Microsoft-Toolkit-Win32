// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using windows = Windows;

namespace Microsoft.Toolkit.Wpf.UI.Controls
{
    /// <summary>
    /// Wpf-enabled wrapper for <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton"/>
    /// </summary>
    public class InkToolbarCustomPenButton : WindowsXamlHostBase
    {
        internal windows.UI.Xaml.Controls.InkToolbarCustomPenButton UwpControl => ChildInternal as windows.UI.Xaml.Controls.InkToolbarCustomPenButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="InkToolbarCustomPenButton"/> class, a
        /// Wpf-enabled wrapper for <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton"/>
        /// </summary>
        public InkToolbarCustomPenButton()
            : this(typeof(windows.UI.Xaml.Controls.InkToolbarCustomPenButton).FullName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InkToolbarCustomPenButton"/> class, a
        /// Wpf-enabled wrapper for <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton"/>.
        /// </summary>
        protected InkToolbarCustomPenButton(string typeName)
            : base(typeName)
        {
        }

        /// <inheritdoc />
        protected override void SetContent()
        {
            if (VisualParent is InkToolbar parent)
            {
                if (parent.GetUwpInternalObject() is windows.UI.Xaml.Controls.InkToolbar toolbar)
                {
                    toolbar.Children.Add(UwpControl);
                }
            }
        }

        /// <inheritdoc />
        protected override void OnInitialized(EventArgs e)
        {
            // Bind dependency properties across controls
            // properties of FrameworkElement
            Bind(nameof(Style), StyleProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.StyleProperty);
            Bind(nameof(MaxHeight), MaxHeightProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MaxHeightProperty);
            Bind(nameof(FlowDirection), FlowDirectionProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.FlowDirectionProperty);
            Bind(nameof(Margin), MarginProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MarginProperty);
            Bind(nameof(HorizontalAlignment), HorizontalAlignmentProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.HorizontalAlignmentProperty);
            Bind(nameof(VerticalAlignment), VerticalAlignmentProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.VerticalAlignmentProperty);
            Bind(nameof(MinHeight), MinHeightProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MinHeightProperty);
            Bind(nameof(Height), HeightProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.HeightProperty);
            Bind(nameof(MinWidth), MinWidthProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MinWidthProperty);
            Bind(nameof(MaxWidth), MaxWidthProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MaxWidthProperty);
            Bind(nameof(UseLayoutRounding), UseLayoutRoundingProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.UseLayoutRoundingProperty);
            Bind(nameof(Name), NameProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.NameProperty);
            Bind(nameof(Tag), TagProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.TagProperty);
            Bind(nameof(DataContext), DataContextProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.DataContextProperty);
            Bind(nameof(Width), WidthProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.WidthProperty);

            // InkToolbarCustomPenButton specific properties
            Bind(nameof(CustomPen), CustomPenProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPenProperty, new WindowsXamlHostWrapperConverter());
            Bind(nameof(ConfigurationContent), ConfigurationContentProperty, windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContentProperty);

            base.OnInitialized(e);
        }

        /// <summary>
        /// Gets <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContentProperty"/>
        /// </summary>
        public static DependencyProperty ConfigurationContentProperty { get; } = DependencyProperty.Register(nameof(ConfigurationContent), typeof(windows.UI.Xaml.UIElement), typeof(InkToolbarCustomPenButton));

        /// <summary>
        /// Gets <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPenProperty"/>
        /// </summary>
        public static DependencyProperty CustomPenProperty { get; } = DependencyProperty.Register(nameof(CustomPen), typeof(InkToolbarCustomPen), typeof(InkToolbarCustomPenButton));

        /// <summary>
        /// Gets or sets <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPen"/>
        /// </summary>
        public InkToolbarCustomPen CustomPen
        {
            get => (InkToolbarCustomPen)GetValue(CustomPenProperty);
            set => SetValue(CustomPenProperty, value);
        }

        /// <summary>
        /// Gets or sets <see cref="windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContent"/>
        /// </summary>
        public windows.UI.Xaml.UIElement ConfigurationContent
        {
            get => (windows.UI.Xaml.UIElement)GetValue(ConfigurationContentProperty);
            set => SetValue(ConfigurationContentProperty, value);
        }
    }
}