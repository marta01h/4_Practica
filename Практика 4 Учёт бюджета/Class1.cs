
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System;

public partial class MainWindow : Window
{
    // ...

    private void DisplayBudgetRecords(DateTime date)
    {
        var filteredRecords = budgetRecords.Where(record => record.Date.Date == date.Date).ToList();
        budgetDataGrid.ItemsSource = filteredRecords;
    }

    private void BudgetDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (budgetDataGrid.SelectedItem is BudgetRecord selectedRecord)
        {
            // Логика отображения выбранной записи в текстовых полях и списках
        }
    }

    // ...
}
