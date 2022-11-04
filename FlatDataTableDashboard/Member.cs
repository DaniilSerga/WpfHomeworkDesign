using System.Windows.Media;

namespace FlatDataTableDashboard
{
    public class Member
    {
        // Символ, необходимый для иконки работника
        public string? Character { get; set; }
        // ID работника
        public int Number { get; set; }
        // ФИО работника
        public string? Name { get; set; }
        // Должность работника
        public string? Position { get; set; }
        // Адрес электронной почты работника
        public string? Email { get; set; }
        // Номер мобильного телефона работника
        public string? Phone { get; set; }
        // Цвет иконки работника
        public Brush? BgColor { get; set; }
    }
}
