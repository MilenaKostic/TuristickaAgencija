using Microsoft.EntityFrameworkCore;
using TuristickaAgencija.Models;
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

namespace TuristickaAgencija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TuristickaAgencijaContext tagencijacontext = new TuristickaAgencijaContext();
        private CollectionViewSource agencijeViewSource;
        private CollectionViewSource vodiciViewSource;
        private CollectionViewSource putovanjaViewSource;
        private CollectionViewSource nudiViewSource;
        private CollectionViewSource klijentiViewSource;
        private CollectionViewSource destinacijeViewSource;
        private CollectionViewSource obuhvataViewSource;
        private CollectionViewSource tipovismestajaViewSource;
        private CollectionViewSource smestajiViewSource;
        private CollectionViewSource prevoznasredstvaViewSource;
        private CollectionViewSource rezervacijeViewSource;
        private CollectionViewSource sedolaziViewSource;
        private CollectionViewSource autobusiViewSource;
        private CollectionViewSource vrsteautomobilaViewSource;
        private CollectionViewSource automobiliViewSource;
        private CollectionViewSource nabavljaViewSource;

        public MainWindow()
        {
            InitializeComponent();

            agencijeViewSource = (CollectionViewSource)FindResource(nameof(agencijeViewSource));
            vodiciViewSource = (CollectionViewSource)FindResource(nameof(vodiciViewSource));
            putovanjaViewSource = (CollectionViewSource)FindResource(nameof(putovanjaViewSource));
            nudiViewSource = (CollectionViewSource)FindResource(nameof(nudiViewSource));
            klijentiViewSource = (CollectionViewSource)(FindResource(nameof(klijentiViewSource)));
            destinacijeViewSource = (CollectionViewSource)(FindResource(nameof(destinacijeViewSource)));
            obuhvataViewSource = (CollectionViewSource)(FindResource(nameof(obuhvataViewSource)));
            tipovismestajaViewSource = (CollectionViewSource)(FindResource(nameof(tipovismestajaViewSource)));
            smestajiViewSource = (CollectionViewSource)(FindResource(nameof(smestajiViewSource)));
            prevoznasredstvaViewSource = (CollectionViewSource)(FindResource(nameof(prevoznasredstvaViewSource)));
            rezervacijeViewSource = (CollectionViewSource)(FindResource(nameof(rezervacijeViewSource)));
            sedolaziViewSource = (CollectionViewSource)(FindResource(nameof(sedolaziViewSource)));
            autobusiViewSource = (CollectionViewSource)(FindResource(nameof(autobusiViewSource)));
            vrsteautomobilaViewSource = (CollectionViewSource)(FindResource(nameof(vrsteautomobilaViewSource)));
            automobiliViewSource = (CollectionViewSource)(FindResource(nameof(automobiliViewSource)));
            nabavljaViewSource = (CollectionViewSource)(FindResource(nameof(nabavljaViewSource)));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tagencijacontext.Agencijas.Load();
            tagencijacontext.Vodics.Load();
            tagencijacontext.Putovanjes.Load();
            tagencijacontext.Nudis.Load();
            tagencijacontext.Klijents.Load();
            tagencijacontext.Destinacijas.Load();
            tagencijacontext.Obuhvata.Load();
            tagencijacontext.Tipsmestajas.Load();
            tagencijacontext.Smestajs.Load();
            tagencijacontext.PrevoznoSredstvos.Load();
            tagencijacontext.Rezervises.Load();
            tagencijacontext.SeDolazis.Load();
            tagencijacontext.Autobus.Load();
            tagencijacontext.vrstaAutomobilas.Load();
            tagencijacontext.Automobils.Load();
            tagencijacontext.Nabavljas.Load();


            agencijeViewSource.Source = tagencijacontext.Agencijas.Local.ToObservableCollection();
            vodiciViewSource.Source = tagencijacontext.Vodics.Local.ToObservableCollection();
            putovanjaViewSource.Source = tagencijacontext.Putovanjes.Local.ToObservableCollection();
            nudiViewSource.Source = tagencijacontext.Nudis.Local.ToObservableCollection();
            klijentiViewSource.Source = tagencijacontext.Klijents.Local.ToObservableCollection();
            destinacijeViewSource.Source = tagencijacontext.Destinacijas.Local.ToObservableCollection();
            obuhvataViewSource.Source = tagencijacontext.Obuhvata.Local.ToObservableCollection();
            tipovismestajaViewSource.Source = tagencijacontext.Tipsmestajas.Local.ToObservableCollection();
            smestajiViewSource.Source = tagencijacontext.Smestajs.Local.ToObservableCollection();
            prevoznasredstvaViewSource.Source = tagencijacontext.PrevoznoSredstvos.Local.ToObservableCollection();
            rezervacijeViewSource.Source = tagencijacontext.Rezervises.Local.ToObservableCollection();
            sedolaziViewSource.Source = tagencijacontext.SeDolazis.Local.ToObservableCollection();
            autobusiViewSource.Source = tagencijacontext.Autobus.Local.ToObservableCollection();
            vrsteautomobilaViewSource.Source = tagencijacontext.vrstaAutomobilas.Local.ToObservableCollection();
            automobiliViewSource.Source = tagencijacontext.Automobils.Local.ToObservableCollection();
            nabavljaViewSource.Source = tagencijacontext.Nabavljas.Local.ToObservableCollection();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tagencijacontext.Dispose();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = tagencijacontext.SaveChanges();

            AgencijeDataGrid.Items.Refresh();
            VodiciDataGrid.Items.Refresh();
            PutovanjaDataGrid.Items.Refresh();
            NudiDataGrid.Items.Refresh();
            KlijentDataGrid.Items.Refresh();
            DestinacijeDataGrid.Items.Refresh();
            ObuhvataDataGrid.Items.Refresh();
            TipsmestajaDataGrid.Items.Refresh();
            SmestajDataGrid.Items.Refresh();
            PrevoznoSredstvoDataGrid.Items.Refresh();
            RezerviseDataGrid.Items.Refresh();
            SeDolaziDataGrid.Items.Refresh();
            AutobusDataGrid.Items.Refresh();
            VrsteAutomobilaDataGrid.Items.Refresh();
            AutomobiliDataGrid.Items.Refresh();
            NabavkaDataGrid.Items.Refresh();


            MessageBox.Show("Broj izvršenih zapisa: " + n, "Snimanje");
        }

          }
}
