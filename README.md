# MAKE_TFTLCD_GUI

개발 툴: Visual Studio 2017

개발 언어: C# winform

목적: STM32 펌웨어에서 TFT LCD 제어에 사용할 이미지 만들기

사용 방법: 

1. sub panel(draw info)의 figure 그룹에서 rectangle, text, image를 선택 (toggle)
2. main panel에서 사용할 object를 편집
    - main panel에 ctrl키를 누른 상태에서 마우스를 드래그하면 1에서 선택한 object가 그려짐
    - 2에서 그려진 object 정보는 draw info의 object info 그룹에 표시됨
    - ctrl을 누르지 않은 상태에서 main panel의 object를 선택하거나 드래그하여 이동 가능 (크기 조절은 불가능)
    - object를 선택한 상태로 delete 키를 누르면 삭제됨
3. Make Source 그룹에서 이름을 입력하고 Make 버튼을 누르면 main panel의 그림을 그릴수있는 펌웨어 소스가 생성됨
4. image로 사용되는 binary 파일은 ImageToArray( https://github.com/NSJ-student/ImageToArray )에서 변환한 파일을 사용
    - 다만 원본 이미지의 크기에 맞추어 변환되므로 이미지 크기를 원하는 크기로 먼저 바꾼 후 bin으로 변환
    - 변환 형식은 565 RGB

# UI

![TFT_LCD](https://user-images.githubusercontent.com/28644565/136659632-aef4535f-1fb4-44e9-9ab4-9d7338de2f9a.PNG)


# 생성된 펌웨어 소스

![TFT_LCD2](https://user-images.githubusercontent.com/28644565/136659882-6621fb5d-55bf-4d7e-b19f-57c0ffa38bfd.PNG)
![TFT_LCD3](https://user-images.githubusercontent.com/28644565/136659883-8c2b7b28-f7ee-450e-a1ce-9743000995c7.PNG)



