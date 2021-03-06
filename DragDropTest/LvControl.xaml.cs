﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DragDropTest
{
    /// <summary>
    /// Interaction logic for LvControl.xaml
    /// </summary>
    public partial class LvControl : UserControl
    {
        public LvControl()
        {
            InitializeComponent();
        }
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>
        {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5",
            "Item6"
        };
    }
}
