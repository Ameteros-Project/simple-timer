namespace maintance
{
    public partial class Form1 : Form
    {
        private int oblivion;
        private string str_oblivion;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000; // �������
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
        // ���������� ������� Tick �������
        void timer1_Tick(object sender, EventArgs e)
        {
            oblivion += 1; // �������� �������
            progressBar1.PerformStep(); // ��� � �������� ����
            //str_oblivion = oblivion.ToString(); // Int � String (��� �����)
            //this.Text = str_oblivion; // �����
            if (oblivion == 10) {
            
              MessageBox.Show(
                 "���! �� ��� ������ ��� ���� �������, �� ����� ���(\n�������� , ���� �� ����� (�����) : https://www.donationalerts.com/r/ametero",
                 "����� ����",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.DefaultDesktopOnly);
            };
        }
    }
}