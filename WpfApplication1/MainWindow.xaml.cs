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
using CTS.ApplicationLayer;
using CTS.BusinessLayer;
using CTS.Reports;
using Application = CTS.ApplicationLayer.Application;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.FillData();
        }

        private void GiveSalaryButton_Click(object sender, RoutedEventArgs e)
        {
            Application.CompanyGiveSalary();
        }

        private void GiveTasksButton_Click(object sender, RoutedEventArgs e)
        {
            Application.CompanyGiveTasks();
        }

        private void MiddleDevelopers_Click(object sender, RoutedEventArgs e)
        {
            Reports.GenerateDevelopersReportByLevel(CompanyStorage.Developers);
        }

        private void TestersSortedBySalary_Click(object sender, RoutedEventArgs e)
        {
            Reports.GenerateReportSortedTestersBySalary(CompanyStorage.Testers);
        }

        private void DevsByAmountOfTasks_Click(object sender, RoutedEventArgs e)
        {
            Reports.GenerateReportSortedDevelopersByTasksAmount(CompanyStorage.Developers);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e) {
            string name = SearchName.Text;
            Reports.GenerateReportFindUsersByName(CompanyStorage.Developers, CompanyStorage.Testers, name);
        }
    }
}
