namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunningButton_MouseEnter(object sender, EventArgs e)
        {
            int x_position = 100; //x좌표를 100으로 설정
            int y_position = 150; //y좌표를 150으로 설정

            RunningButton.Location = new Point(x_position, y_position);//나를 잡아봐 버튼의 좌표
        }

        
    }
}
