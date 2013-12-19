using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPosition
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initalize();
        }
        public List<SampleItem> Items { get; set; }

        private void Initalize()
        {
            list.ItemsSource = Items = new List<SampleItem>{
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="Hello"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
               new SampleItem{Name="World"},
           };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          var item =  GetItem();

           var transform= item.TransformToAncestor(list);
          Point point =  transform.Transform(new Point(0,0));
              MessageBox.Show(string.Format("x:{0},y:{1}",point.X,point.Y));
        }

        private ListBoxItem GetItem()
        {
            var index = int.Parse(tb1.Text);
            ListBoxItem item = list.ItemContainerGenerator.ContainerFromIndex(index) as ListBoxItem;
            return item;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var item = GetItem();
            Vector vect = VisualTreeHelper.GetOffset(item);
            MessageBox.Show(string.Format("x:{0},y:{1}", vect.X, vect.Y));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var item = GetItem();
            var trans = new TranslateTransform();
            trans.X = -1;
           // trans.Y = 0.5;
            item.RenderTransform = trans;
        }
    }

    public class SampleItem
    {
        public string Name { get; set; }
    }
}
