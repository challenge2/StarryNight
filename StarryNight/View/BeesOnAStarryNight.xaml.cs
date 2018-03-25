using System.Windows;
using StarryNight.ViewModel;

namespace StarryNight.View
{
    public partial class BeesOnAStarryNight : Window
    {
        ViewModel.BeeStarViewModel viewModel;

        public BeesOnAStarryNight()
        {
            InitializeComponent();

            viewModel = FindResource("viewModel") as ViewModel.BeeStarViewModel;
        }

        private void SizeChangedHandler(object sender, SizeChangedEventArgs e)
        {
            viewModel.PlayAreaSize = new Size(e.NewSize.Width, e.NewSize.Height);
        }  //  *
    }
}
