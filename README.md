# Taiko_Run_Away



## 🏃‍♂️ 프로젝트 소개
강의에서 배운 내용을 바탕으로 Unity의 Collider를 주로 활용한 3D 러닝 액션게임 “태고의 달려”



📕 [태고의 달인 팀 노션](https://www.notion.so/teamsparta/cbecffec43504aa89093ef9601d8aa75)



## 🕓 개발 기간
- 2024.06.03 ~ 06.10
- 사전 기획 (06.03)
-   프로젝트 역할 분담
-   와이어프레임 작성
- 개발 (06.04 ~ 06.09)
-   태고의 달려 게임 전반적인 시스템 구현
- 프로젝트 검토 (06.10)
-   버그 수정
-   코드 리팩토링
- 문서화 (06.10)
- Readme 및 PPT 등 자료 준비



## 👦 개발자
- 팀장 | 김재휘
- 팀원 | 김경찬, 김성훈, 문향기



## 💬 프로젝트 설명
인도에 살고 있던 동디가 마스코트의 자리를 차지하기 위해 동이에게 인도로 출장 와달라고 요청한 후, 
본인은 일본으로 가서 마스코트 자리를 차지하려 시도한다.
그 사실을 알게 된 동이는 동디를 막기 위해 귀국하기 위한 긴급 자금을 몹기 시작하는데...
(마침 엔저라서 더 쉽게 갈 수 있을거 같다!)



- 게임 시작 화면
-   3개의 버튼 - 게임 스토리, 게임 설명, 게임 시작 버튼
-   게임 스토리 버튼을 누르면 게임 스토리가 뜨고 그 아래 게임 설명 버튼 위치
-   게임 설명 버튼을 누르면 조작법 설명
-   게임 시작 버튼을 누르면 게임 플레이 화면으로 이동
-   📘 [시작 버튼 스크립트](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/GameStartBtn.cs)
-   📘 [시작 화면 스크립트](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/StartManager.cs)
-   📘 [시작 화면 버튼 관리 스크립트](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/VariousBtn.cs)

- 게임 플레이 화면
-   
-   📙 [게임 매니저](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/SH_Temp_Scripts/Game/GameManager.cs)
-   📙 [오디오 매니저](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/SH_Temp_Scripts/Game/AudioManager.cs)
-   📙 [점수 관리](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/SH_Temp_Scripts/Game/Score.cs)
-   📙 [빌딩](https://github.com/kyeongchanunity4/Taiko_Run_Away/tree/main/Assets/01_Scripts/SH_Temp_Scripts/Building)
-   📙 [코인](https://github.com/kyeongchanunity4/Taiko_Run_Away/tree/main/Assets/01_Scripts/SH_Temp_Scripts/Impediment)
-   📙 [플레이어 상태](https://github.com/kyeongchanunity4/Taiko_Run_Away/tree/main/Assets/01_Scripts/SH_Temp_Scripts/Player)
-   📙 [플레이어 움직임](https://github.com/kyeongchanunity4/Taiko_Run_Away/tree/main/Assets/Scirpts)
-   📙 [종료 버튼](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/FinishBtn.cs)
-   📙 [일시 정지 버튼](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/PauseBtn.cs)
-   📙 [다시 시작 버튼](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/RetryBtn.cs)
-   📙 [타이틀 버튼](https://github.com/kyeongchanunity4/Taiko_Run_Away/blob/main/Assets/01_Scripts/Chan_Temp_Scripts/Btn/TitleBtn.cs)
