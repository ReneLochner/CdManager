using CdManager.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CdManager
{
    /// <summary>
    /// Interaction logic for AddCdWindow.xaml
    /// </summary>
    public partial class AddCdWindow : Window
    {
        Cd newCd;
        public AddCdWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(AddCdWindow_Loaded);
        }

        void AddCdWindow_Loaded(object sender, RoutedEventArgs e)
        {
            btnSave.Click += new RoutedEventHandler(btnSave_Click);
            btnCancel.Click += new RoutedEventHandler(btnCancel_Click);

            newCd = new Cd();
            newCd.AlbumTitle = "< hier Titel eingeben >";
            grdCdFields.DataContext = newCd;
        }

        void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Repository.GetInstance().AddCd(newCd);
            Close();
        }

        void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
