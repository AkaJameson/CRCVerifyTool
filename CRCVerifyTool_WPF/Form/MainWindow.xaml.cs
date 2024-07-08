using CRCVerifyTool_WPF.ViewModel;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRCVerifyTool_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly VerifyViewModel _viewModel = new VerifyViewModel();
        public MainWindow()
        {
            InitializeComponent();
            btnMin.Click += (s, e) => { this.WindowState = WindowState.Minimized; };
            btnMax.Click += (s, e) =>
            {
                if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;
                else this.WindowState = WindowState.Maximized;
            };
            btnClose.Click += (s, e) => { this.Close(); };

            this.DataContext = _viewModel;

        }


        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择上传文件";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            bool? fileResult = openFileDialog.ShowDialog();
            if (fileResult == true)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                if (fileInfo.Length > 2000)
                {
                    MessageBox.Show("文件过大，读取文件失败");
                    return;
                }
                (this.DataContext as VerifyViewModel).FileInfo = File.ReadAllBytes(fileInfo.FullName);
                MessageBox.Show("文件读取成功");
            }

        }
    }
}