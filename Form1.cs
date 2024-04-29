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
        // каждый тик таймера (1 секунда) таймер
        void timer1_Tick(object sender, EventArgs e)
        {
            oblivion += 1; // Типо отсчёт, лол
            progressBar1.PerformStep(); // Добавляем прогресса к обучению C#
            //str_oblivion = oblivion.ToString(); // Int â String (Для хуйни)
            //this.Text = str_oblivion; // хуйня
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
