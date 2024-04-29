namespace maintance
{
    public partial class Form1 : Form
    {
        private int oblivion;
        private string str_oblivion;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000; // секунда
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
        // обработчик события Tick таймера
        void timer1_Tick(object sender, EventArgs e)
        {
            oblivion += 1; // Колхозим счётчик
            progressBar1.PerformStep(); // Шаг к прогресс бару
            //str_oblivion = oblivion.ToString(); // Int в String (Для Хуйня)
            //this.Text = str_oblivion; // Хуйня
            if (oblivion == 10) {
            
              MessageBox.Show(
                 "Хай! Ну тут должен был быть скрэмер, но денег нет(\nПоддержи , если не похуй (похуй) : https://www.donationalerts.com/r/ametero",
                 "Адмен блэт",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);
            };
        }
    }
}