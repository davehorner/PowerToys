﻿using System;
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

using ColorPicker.ColorPickingFunctionality;
using ColorPicker.ColorPickingFunctionality.SystemEvents;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegisterdMouseEventHook mouseEvent;
        public MainWindow()
        {
            InitializeComponent();
            mouseEvent = new RegisteredMouseEventHook(PixelColorFinder.HandleMouseClick);
        }
    }
}