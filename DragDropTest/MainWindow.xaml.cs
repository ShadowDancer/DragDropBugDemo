using System.Collections.ObjectModel;
using System.Windows;

namespace DragDropTest
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ObservableCollection<TestTree> Tree { get; } = new ObservableCollection<TestTree>
        {
            new TestTree
            {
                Text = "root",
                Children = new ObservableCollection<TestTree>
                {
                    new TestTree
                    {
                        Text = "Item1",
                        Children = new ObservableCollection<TestTree>(),
                        Items = new ObservableCollection<string>
                        {
                            "Item1",
                            "Item2",
                            "Item3",
                            "Item4",
                            "Item5"
                        }
                    },
                    new TestTree
                    {
                        Text = "Item2",
                        Children = new ObservableCollection<TestTree>(),
                        Items = new ObservableCollection<string>
                        {
                            "Item1",
                            "Item2",
                            "Item3",
                            "Item4",
                            "Item5"
                        }
                    }
                }
            }
        };
    }
}