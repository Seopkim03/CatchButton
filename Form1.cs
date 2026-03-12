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

        int score = 1000; // 초기점수 1000점으로 설정

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
            this.Text = $"버튼 위치: ({nextX}, {nextY}) | 점수 : {score}";

            // 수정된 코드: RunningButton 자체의 Cursor 속성을 설정
            RunningButton.Cursor = Cursors.Hand; // 버튼 위에 마우스가 올라갔을 때 손 모양으로 커서 변경
        }

        private void RunningButton_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SystemSounds.Beep.Play(); // 버튼을 눌렀을 때 소리 출력
            score += 100; //버튼을 눌렀을 때 점수를 추가
            //MessageBox.Show("축하합니다"); // 버튼을 눌렀을 때 메세지 박스 표시
        }

        private void RunningButton_MouseLeave(object sender, EventArgs e)
        {
            Console.Beep(); // 버튼에서 마우스가 떠날 때 소리 출력
            score -= 10; // 버튼을 놓쳤을 때 점수 10점 감점
        }

        private void RunningButton_MouseUp(object sender, MouseEventArgs e)
        {
            
            Random rd = new Random();
            
            int maxX = this.ClientSize.Width - RunningButton.Width;
            int maxY = this.ClientSize.Height - RunningButton.Height;
            
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            RunningButton.Location = new Point(nextX, nextY);
            this.Text = $"버튼 위치: ({nextX}, {nextY}) | 점수 : {score}";
            //버튼을 누르면 버튼이 다시 도망가도록 설정

            RunningButton.Size = new Size(RunningButton.Width -10, RunningButton.Height - 10); // 버튼을 누를 때마다 버튼 크기 감소
        }
    }
}
