using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FlatDataTableDashboard
{
    public partial class MainWindow : Window
    {
        // Список всех работников
        private readonly ObservableCollection<Member> _members = new();
        // Поле, сообщающее о состоянии экрана (максимизировано/минимизировано)
        private bool _isMaximized = false;

        public MainWindow()
        {
            InitializeComponent();

            membersDataGrid.ItemsSource = _members;

            LoadDataInDataGrid();
        }

        // Метод реализующий возможность перемещения окна приложения по экрану
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        // Метод, добавляющий возможность развернуть приложения на весь экран двойным щелчком левой клавишей мыши
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (_isMaximized)
                {
                    WindowState = WindowState.Normal;
                    Width = 1080;
                    Height = 720;

                    _isMaximized = false;
                }
                else
                {
                    WindowState = WindowState.Maximized;

                    _isMaximized = true;
                }
            }
        }

        // Метод, загружающий данные в DataGrid
        private void LoadDataInDataGrid()
        {
            var converter = new BrushConverter();

            // Create DataGrid Items Info
            _members.Add(new Member { Number = 1, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad")!, Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            _members.Add(new Member { Number = 2, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Deza Alavi", Position = "Administrator", Email = "reza11@hotmail.com", Phone = "254-451-7893" });
            _members.Add(new Member { Number = 3, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00")!, Name = "Dennis Castillo", Position = "Coach", Email = "dent.cast@gmail.com", Phone = "125-520-0141" });
            _members.Add(new Member { Number = 4, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            _members.Add(new Member { Number = 5, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Lena Jones", Position = "Manager", Email = "len.off@hotmail.com", Phone = "320-658-9174" });
            _members.Add(new Member { Number = 6, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9")!, Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            _members.Add(new Member { Number = 7, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00")!, Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            _members.Add(new Member { Number = 8, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            _members.Add(new Member { Number = 9, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            _members.Add(new Member { Number = 10, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });

            _members.Add(new Member { Number = 11, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad")!, Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            _members.Add(new Member { Number = 12, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Deza Alavi", Position = "Administrator", Email = "reza11@hotmail.com", Phone = "254-451-7893" });
            _members.Add(new Member { Number = 13, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00")!, Name = "Dennis Castillo", Position = "Coach", Email = "dent.cast@gmail.com", Phone = "125-520-0141" });
            _members.Add(new Member { Number = 14, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            _members.Add(new Member { Number = 15, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Lena Jones", Position = "Manager", Email = "len.off@hotmail.com", Phone = "320-658-9174" });
            _members.Add(new Member { Number = 16, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9")!, Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            _members.Add(new Member { Number = 17, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00")!, Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            _members.Add(new Member { Number = 18, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            _members.Add(new Member { Number = 19, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            _members.Add(new Member { Number = 20, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });

            _members.Add(new Member { Number = 21, Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad")!, Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            _members.Add(new Member { Number = 22, Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Deza Alavi", Position = "Administrator", Email = "reza11@hotmail.com", Phone = "254-451-7893" });
            _members.Add(new Member { Number = 23, Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00")!, Name = "Dennis Castillo", Position = "Coach", Email = "dent.cast@gmail.com", Phone = "125-520-0141" });
            _members.Add(new Member { Number = 24, Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            _members.Add(new Member { Number = 25, Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Lena Jones", Position = "Manager", Email = "len.off@hotmail.com", Phone = "320-658-9174" });
            _members.Add(new Member { Number = 26, Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9")!, Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" });
            _members.Add(new Member { Number = 27, Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00")!, Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" });
            _members.Add(new Member { Number = 28, Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252")!, Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" });
            _members.Add(new Member { Number = 29, Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5")!, Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" });
            _members.Add(new Member { Number = 30, Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678")!, Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" });
        }

        // Событие нажатия на кнопку выхода, закрывающее приложение
        private void LogoutButton_Click(object sender, RoutedEventArgs e) => Close();
    }
}
