using System;
using TimeTrack.Client.UWP.Utils;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TimeTrack.Client.UWP
{
    [TemplatePart(Name = "elementToFocus", Type = typeof(Control))]
    public class StylizedControl : Control
    {
        public StylizedControl()
        {
            this.WatchProperty("Visibility", VisibilityChanged);
            IsTabStop = false;
        }

        private void VisibilityChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateFocus();
        }

        private void UpdateFocus()
        {
            if (Visibility == Visibility.Visible)
            {
                var focusControl = GetTemplateChild("elementToFocus") as Control;
                if (focusControl != null)
                {
                    focusControl.Focus(Windows.UI.Xaml.FocusState.Pointer);
                }
            }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            UpdateFocus();
        }

        public string StyleName
        {
            get { return (string)GetValue(StyleNameProperty); }
            set { SetValue(StyleNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PageStyle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StyleNameProperty =
            DependencyProperty.Register("StyleName", typeof(string), typeof(StylizedControl), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnStyleNameChanged)));

        private static void OnStyleNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as StylizedControl).LoadStyle((string)e.NewValue);
        }

        private void LoadStyle(string styleName)
        {
            if (string.IsNullOrEmpty(styleName))
            {
                Style = null;
                return;
            }
            var res = new ResourceDictionary { Source = new Uri("ms-appx:///Themes/Generic.xaml", UriKind.Absolute) };
            Style = (Style)res[styleName];
        }
    }
}
