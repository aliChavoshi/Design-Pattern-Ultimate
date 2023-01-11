
using ConsoleApp1.observer;

var dataSource = new DataSource();
//observer
var spreadSheet = new SpreadSheet(dataSource);
var chart = new Chart(dataSource);
//attach observer for updating
dataSource.Attach(spreadSheet);
dataSource.Attach(chart);

dataSource.Value = "A";
dataSource.Value = "B";