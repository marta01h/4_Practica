
using System.Windows;
using System;

public partial class AddRecordWindow : Window
{
    public event EventHandler<BudgetRecordEventArgs> RecordAdded;
    private void AddRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Создать новую запись на основе введенных данных
        var newRecord = new BudgetRecord
        {
            Name = nameTextBox.Text,
            Type = typeComboBox.SelectedItem.ToString(),
            Amount = decimal.Parse(amountTextBox.Text),
            IsIncome = isIncomeCheckBox.IsChecked ?? false,
            Date = DateTime.Now
        };

        // Вызвать событие добавления новой записи
        RecordAdded?.Invoke(this, new BudgetRecordEventArgs(newRecord));

        // Закрыть окно
        Close();
    }
}

// Аргументы события добавления записи
public class BudgetRecordEventArgs : EventArgs
{
    public BudgetRecord Record { get; }

    public BudgetRecordEventArgs(BudgetRecord record)
    {
        Record = record;
    }
}
