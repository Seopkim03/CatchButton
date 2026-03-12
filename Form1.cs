namespace CatchButton
{
    public partial class Form1 : Form
    {
        // IDE0044: 필드를 읽기 전용으로 만들기
        private readonly string str = "Catch the button version 1.2";

        public Form1()
        {
            InitializeComponent();
            // 폼 제목에 초기 문자열 설정
            this.Text = str;
        }

        private void RunningButton_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수 생성기 준비
            Random rd = new Random();
            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - RunningButton.Width;
            int maxY = this.ClientSize.Height - RunningButton.Height;
            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치 할당 (새로운 Point 객체 생성)
            RunningButton.Location = new Point(nextX, nextY);
            // 5. 시각적 피드백 (폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
