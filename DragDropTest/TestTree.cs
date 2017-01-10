using System.Collections.ObjectModel;

namespace DragDropTest
{
    public class TestTree
    {
        public ObservableCollection<TestTree> Children { get; set; } = new ObservableCollection<TestTree>();

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();
        public string Text { get; set; }
    }
}