## 버튼잡기게임(C# 코딩)
개요: C# 프로그래밍 학습
핵심기능: 버튼 클릭 성공 시 점수 +100, 축하합니다 메세지 박스, 난이도 상승(버튼 크기 10% 감소) / 클릭 실패 시 : 점수 -10, 20번 누적 실패 시 게임오버 및 게임 리셋, 상단부에 점수, 실패 횟수, 좌표 기재
화면구성: 상단 제목 부분 점수 | 실패 횟수 | 버튼 좌표, 버튼 창 내부에서 랜덤 이동, 하단부 우측 리셋버튼(게임오버시에만 visibe = true)

## 실행화면
- 1단계 코드의 실행 스크린샷
<img width="837" height="454" alt="1단계 구현" src="https://github.com/user-attachments/assets/c1bdd687-ca79-426d-a164-5c8a9b3e00c2" /> - 버튼의 랜덤 이동, 좌표 구현

- 2단계 코드의 실행 스크린샷
<img width="825" height="442" alt="2단계 구현" src="https://github.com/user-attachments/assets/cb121c0d-5850-4aa4-a161-518e0ee27258" /> - 잡기 성공 시의 메시지 박스 구현

- 3단계 코드의 실행 스크린샷
<img width="829" height="441" alt="3단계 구현" src="https://github.com/user-attachments/assets/1903c8a3-9398-4bf5-8652-fb122dbf3f5b" /> - 점수 및 난이도 조절 구현

- 4단계 코드의 실행 스크린샷
<img width="832" height="446" alt="4단계 게임오버구현" src="https://github.com/user-attachments/assets/7d6e5600-fe9b-4864-a7fa-94440faac7c6" />- 게임 오버시 화면 구현
<img width="828" height="433" alt="4단계 재시작 구현" src="https://github.com/user-attachments/assets/56a8fc6e-4841-4602-9ed6-b0bfa51920cf" />- 게임 재시작 구현

## 구현시어려웠던점
버튼을 누르기 전에 그냥 버튼 위에 마우스가 있다가 누르지 않으면 소리가 계속 나는 문제가 있어서 ai를 이용하여 무엇이 문제인지 확인하고 화면 클릭 시에 실패 소리를 넣으면 해결된다는 것을 확인하였습니다.
이후 Space와 Enter를 눌렀을 때 버튼이 눌려서 게임이 통과되는 걸로 처리가 되어 Space와 Enter를 비활성화 시켰습니다
게임이 오버된 후 리셋버튼을 어디에 넣을 지 고민하다가 ai의 도움을 받아 시작에는 visible을 flase로 설정하고 게임 오버시에 리셋버튼의 visible을 true로 변경하는 것으로 해결하였습니다.
