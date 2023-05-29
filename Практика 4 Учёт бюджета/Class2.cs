
using System.Windows;

public partial class MainWindow : Window
{
    private void AddRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Открыть окно добавления новой записи
        var addRecordWindow = new AddRecordWindow();
        addRecordWindow.RecordAdded += AddRecordWindow_RecordAdded;
        addRecordWindow.ShowDialog();
    }

    private void AddRecordWindow_RecordAdded(object sender, BudgetRecordEventArgs e)
    {
        // Обработчик события добавления новой записи из окна добавления записи
        budgetRecords.Add(e.Record);
        SaveBudgetRecords();
        DisplayBudgetRecords(selectedDate);
    }
}