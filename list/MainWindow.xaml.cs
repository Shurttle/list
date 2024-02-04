﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace list
{
   
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string newMessage = NewMessageTextBox.Text;
            if (!string.IsNullOrWhiteSpace(newMessage))
            {
                MessageListBox.Items.Add(newMessage);
                NewMessageTextBox.Clear();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageListBox.SelectedIndex != -1)
            {
                MessageListBox.Items.RemoveAt(MessageListBox.SelectedIndex);
            }
        }
            private void SendMessageButton_Click(object sender, RoutedEventArgs e)
            {
                string newMessage = NewMessageTextBox.Text;
                if (!string.IsNullOrWhiteSpace(newMessage))
                {
                    MessageListBox.Items.Add(newMessage);
                    NewMessageTextBox.Clear();
                }
            }        
    }
}