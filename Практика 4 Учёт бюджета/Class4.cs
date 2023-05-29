
using System.Windows;

public partial class MainWindow : Window
{
    private void DeleteRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Удаление выбранной записи из таблицы
        if (budgetRecordsGrid.SelectedItem is BudgetRecord selectedRecord)
        {
            budgetRecords.Remove(selectedRecord);
            SaveBudgetRecords();
            DisplayBudgetRecords(selectedDate);
        }
    }
}
