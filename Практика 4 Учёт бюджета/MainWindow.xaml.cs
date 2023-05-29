using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
// Класс модели записи бюджета
public class BudgetRecord
{
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public bool IsIncome { get; set; }
    public DateTime Date { get; set; }

    public BudgetRecord(string name, string type, decimal amount, bool isIncome, DateTime date)
    {
        Name = name;
        Type = type;
        Amount = amount;
        IsIncome = isIncome;
        Date = date;
    }
}

// Класс для сериализации/десериализации данных
public static class DataSerializer
{
    public static void Serialize<T>(T data, string filePath)
    {
        // Логика сериализации данных в файл
    }

    public static T Deserialize<T>(string filePath)
    {
        // Логика десериализации данных из файла
        return default(T);
    }
}

// Основной класс приложения
public partial class MainWindow : Window
{
    private List<BudgetRecord> budgetRecords;
    private List<string> recordTypes;

    public MainWindow()
    {
        InitializeComponent();

        // Инициализация данных
        budgetRecords = DataSerializer.Deserialize<List<BudgetRecord>>("budget_records.json");
        recordTypes = DataSerializer.Deserialize<List<string>>("record_types.json");

        // Отображение данных на сегодняшнюю дату
        DisplayBudgetRecords(DateTime.Today);
    }

    private void DisplayBudgetRecords(DateTime date)
    {
        // Логика отображения записей бюджета на указанную дату
    }

    private void AddNewRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Логика добавления новой записи
    }

    private void UpdateRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Логика обновления выбранной записи
    }

    private void DeleteRecordButton_Click(object sender, RoutedEventArgs e)
    {
        // Логика удаления выбранной записи
    }

    private void SaveData()
    {
        DataSerializer.Serialize(budgetRecords, "budget_records.json");
        DataSerializer.Serialize(recordTypes, "record_types.json");
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        SaveData();
        base.OnClosing(e);
    }
}
