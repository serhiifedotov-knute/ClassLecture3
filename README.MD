
*GIT INSTRUCTIONS*

```
git status  - воно показує нові зміни у проєкті
git add назва файлу - воно додає зміни у проєкті
git add . - воно додає УСІ змінені файли
git commit -m "Що було зроблено" - ця команда зберігає на постійній основі зміну

будь яка зміна ще
git diff - вона показує різницю змін між останьою копією ( які ще не збережені командою git commit)


git clone git@github.com:serhiifedotov-knute/ClassLecture3.git
git push origin "назва гілки" - зберегти локальні зміни в репозиторії на віддаленому репозиторії 
git pull origin "назва гілки" - отримати зміни з віддаленого репозиторію у своєму локальному репорзиторії
git log --oneline --graph -50 - подивитися остані 50 змін

git checkout -b "назва гілка" - це створює копію проєкту лише для мене( розробника)
git branch "назва гілка" - це створює копію проєкту лише для мене( розробника)


git checkout "branch-name" - перейти на проєкт у стані цієї гілки
git checkout "file-name" - повертає зміни файли до стану у гілці

git merge "branch name" - вона об'єдную дві гілки ( версії проєкту в одну)

git remote add origin git@github.com:serhiifedotov-knute/ClassLecture3.git - під'єднати віддалений сервер
git remote rm origin - видалити посилання на віддалений сервер

git blame "file name/file path" - показує хто останій робив зміни
```
