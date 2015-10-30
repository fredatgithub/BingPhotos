using System;
using System.Windows;

namespace BingPhotoOfDayClient
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
      try
      {
        BingWallPaperClient client = new BingWallPaperClient();
        await client.DownloadAsync();
        BingPhoto.Source = client.WpfPhotoOfTheDay;
        CopyRightData.Text = client.CoppyRightData;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }
    }
  }
}
