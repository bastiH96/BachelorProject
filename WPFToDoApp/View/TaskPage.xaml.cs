using System;
using System.Collections.Generic;
using System.Linq;
namespace WPFToDoApp.View;

using System.Windows.Controls;
using WPFToDoApp.ViewModel;


public partial class TaskPage : Page
{
    public TaskPage()
    {
        this.InitializeComponent();
        this.DataContext = new TaskPageViewModel();
    }
}

