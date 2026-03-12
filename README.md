#버튼 잡기 게임 (C# 코딩)

##개요
-C# 프로그래밍 학습
-핵심 기능
:마우스 커서가 버튼 안으로 들어가면 화면 내 랜덤 좌표로 버튼이 이동

-화면 구성
:"나를 잡아봐" 버튼
:Text에 버튼의 랜덤 좌표를 표시

##실행화면
-1단계 : 마우스 커서의 랜덤 이동
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/f6433404-c2da-44b3-aeda-19219d06d68e" />
초기화면
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/02f84f18-2d70-4161-8ea3-c7c7f6cf7ee9" />
랜덤 이동

-2단계 : 버튼을 잡거나 놓쳤을 때 효과음 추가, 버튼을 잡았을 때 메세지 박스 출력, 버튼 위에 마우스 커서가 올라가면 커서 아이콘 변경
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5bd762c0-99df-4d7c-928b-c971a5d59862" />
버튼을 놓치면 효과음 출력, 랜덤 좌표 이동
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/4e21361a-e0b4-48fd-8027-b7b917d09429" />
버튼을 잡으면 "축하합니다" 메세지 박스 출력

-3단계 : 버튼을 잡으면 점수 100점 추가, 버튼을 놓치면 점수 10점 감점. 버튼을 잡을 때마다 버튼의 크기가 감소. 2단계의 버튼을 누를 때 나오던 "축하합니다" 메세지 삭제
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/57cb9d76-1e3a-4dde-9710-7be8ef46f88b" />
초기화면 (기본 점수 1000점 추가)
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/d4336976-7e6e-4780-8c53-6f476b6bc38d" />
버튼을 놓치면 10점 감점
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/9a7938fc-7da8-42f0-ad7a-324d77feef13" />
버튼을 잡으면 100점 추가, 랜덤 좌표 이동, 버튼 크기 감소

//3단계 추가 : 작아지는 버튼의 크기에 맞게 글자의 크기도 감소
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/3eedb75c-78a2-4145-9489-485996ea5b8f" />
버튼 크기에 맞게 폰트를 변경하도록 변경
