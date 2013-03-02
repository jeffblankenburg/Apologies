using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Apologies
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameBoard : Page
    {
        public GameBoard()
        {
            this.InitializeComponent();
            this.SizeChanged += GameBoard_SizeChanged;
        }

        void GameBoard_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ResizeBoard();
        }

        private void ResizeBoard()
        {
            double w = Windows.UI.Xaml.Window.Current.Bounds.Width;
            double h = Windows.UI.Xaml.Window.Current.Bounds.Height;

            double remaining = w - h;

            Left.Width = new GridLength(remaining / 2);
            Right.Width = new GridLength(remaining / 2);
            Center.Width = new GridLength(h);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ResizeBoard();
        }
    }
}
