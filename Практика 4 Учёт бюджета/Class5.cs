
using System.Windows.Controls;
using System.Windows;
using System;

public partial class MainWindow : Window
{
   
    private void AddRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Добавление новой записи в таблицу
        string name = nameTextBox.Text;
        string type = typeComboBox.SelectedItem.ToString();
        decimal amount = decimal.Parse(amountTextBox.Text);
        bool isIncome = isIncomeCheckBox.IsChecked ?? false;
        DateTime date = datePicker.SelectedDate ?? DateTime.Now;

        BudgetRecord newRecord = new BudgetRecord(name, type, amount, isIncome, date);
        budgetRecords.Add(newRecord);
        SaveBudgetRecords();
        DisplayBudgetRecords(selectedDate);

        // Очистка полей ввода
        ClearInputFields();
    }

    private void UpdateRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Обновление выбранной записи в таблице
        if (budgetRecordsGrid.SelectedItem is BudgetRecord selectedRecord)
        {
            selectedRecord.Name = nameTextBox.Text;
            selectedRecord.Type = typeComboBox.SelectedItem.ToString();
            selectedRecord.Amount = decimal.Parse(amountTextBox.Text);
            selectedRecord.IsIncome = isIncomeCheckBox.IsChecked ?? false;
            selectedRecord.Date = datePicker.SelectedDate ?? DateTime.Now;

            SaveBudgetRecords();
            DisplayBudgetRecords(selectedDate);
        }
    }

    private void ClearInputFields()
    {
        // Очистка полей ввода
        nameTextBox.Text = string.Empty;
        typeComboBox.SelectedItem = null;
        amountTextBox.Text = string.Empty;
        isIncomeCheckBox.IsChecked = false;
        datePicker.SelectedDate = DateTime.Now;
    }

}
