// Основной класс приложения
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System;

public partial class MainWindow : Window
{
    private void DisplayBudgetRecords(DateTime date)
    {
        // Отображение записей на выбранную дату в таблице
        var filteredRecords = budgetRecords.Where(record => record.Date.Date == date.Date);
        budgetRecordsGrid.ItemsSource = filteredRecords;
    }

    private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
    {
        // Изменение выбранной даты и отображение соответствующих записей
        selectedDate = datePicker.SelectedDate ?? DateTime.Now;
        DisplayBudgetRecords(selectedDate);
    }

    private void BudgetRecordsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Обработка выбора записи из таблицы
        if (budgetRecordsGrid.SelectedItem is BudgetRecord selectedRecord)
        {
            // Заполнение полей ввода данными выбранной записи
            nameTextBox.Text = selectedRecord.Name;
            typeComboBox.SelectedItem = selectedRecord.Type;
            amountTextBox.Text = Math.Abs(selectedRecord.Amount).ToString();
            isIncomeCheckBox.IsChecked = selectedRecord.IsIncome;
            datePicker.SelectedDate = selectedRecord.Date;
        }
    }

}
