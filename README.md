# BehaviorTree
Mata Kuliah Game Artificial Intelligence Semester 5 Prodi Teknologi Permainan STMM MMTC Yogyakarta 2023

- Source code: https://github.com/wewnumam/BehaviorTree
- Engine: Unity 2021.3.15f1
- Package: [Behavior Bricks](https://assetstore.unity.com/packages/tools/visual-scripting/behavior-bricks-74816)
- Assets: [Starter Assets - Third Person Character Controller](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-urp-196526)

## Behavior Tree
![Imgur](https://i.imgur.com/DZDs7sd.png)

- ***player*** - target yang dikejar oleh Enemy
- ***wanderArea*** - area dimana Enemy akan bergerak random (patroli) 
- ***wanderTarget*** - target hasil random oleh ***wanderArea***
- ***enemyAnimator***, ***enemyNavmeshAgent*** - komponen yang akan dimodikasi properti speednya oleh behavior tree 


## Terdapat 3 behavior pada Enemy:

1. Ketika Enemy menyentuh Player, maka Enemy akan berhenti ![Imgur](https://i.imgur.com/68zXUc9.png)
2. Ketika Enemy berjarak dekat dengan Player, maka Enemy akan mengejar Player ![Imgur](https://i.imgur.com/t58iG4N.png)
3. Ketika tidak ada Player di sekitar Enemy, maka Enemy akan bergerak random di area Wander ![Imgur](https://i.imgur.com/GjfFsT9.png)


## Video Gameplay

![](https://media.giphy.com/media/cEHkVzmhoKnUaiSgEV/giphy.gif)