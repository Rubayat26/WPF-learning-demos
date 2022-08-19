using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;


namespace WpfTutorialSamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender,
StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            if (e.Args.Length == 1)
                
                wnd.OpenFile(e.Args[0]);  //openFile is decribed in 
                                          //MainWindow.xaml.cs file 

            
                //MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            wnd.Show();
            
        }
    }
}

// The StartupEventArgs is what we use here. Its passed into the
// application StartupVent, with the name e. It has the property Args,
// which is a rray of srtring