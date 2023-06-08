# Akasha Scanner на русском

Инструмент Genshin Impact, который извлекает данные вашей учетной записи, включая достижения, персонажей, артефакты и оружие.
Оригинал ветки и софта : [AkashaScanner](https://github.com/xenesty/AkashaScanner) 

[Демонстрационное видео для сканирования достижений](https://github.com/xenesty/AkashaScanner/discussions/3)


## Содержание

- [Особенности](#Особенности)
- [Начало работы](#Начало_работы)
- [Использование](#Использование)
- [FAQ](#faq)
- [Перевод](#Перевод)
- [Возможные обновления](#Возможные_обновления)
- [Вклад](#Вклад)
    - [Сообщение об ошибках](#Сообщение_об_ошибках)
    - [Отправка запросов на исправление](#Отправка_запросов_на_исправление)
- [Благодарности](#Благодарности)
- [Лицензия](#Лицензия)


## Особенности

- Сканирует достижения, персонажей, артефакты и оружие, автоматически делая и анализируя скриншоты игры
- Экспортирует достижения (и персонажей) в формат, совместимый с [Paimon.moe](https://paimon.moe) и [Seelie.me](https://seelie.me) - инструмент для отслеживания прогресса достижений.
- Экспортирует игровые данные в `GOOD`,
формат, совместимый с такими инструментами, как
[Оптимизатор Genshin](https://frzyc.github.io/genshin-optimizer),
[Калькулятор GI DMG](https://gidmgcalculator.github.io/csb-g7is6)
и [Калькулятор влияния Геншина Аспирина](https://genshin.aspirine.su).

> **Примечание**
>
> Этот проект находится в стадии бета-версии. Его можно использовать прямо сейчас, но будущие изменения могут сделать недействительными ваши существующие данные сканирования.


## Начало_работы

Скачайте последнюю версию Akasha Scanner [здесь](https://github.com/xenesty/AkashaScanner/releases/latest) и распакуйте его файлы.

На вашем компьютере должен быть установлен Genshin Impact.
Вам также потребуется установить
[Microsoft Visual C++ Redistributable](https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170#visual-studio-2015-2017-2019-and-2022)
([Прямая ссылка на скачивание](https://aka.ms/vs/17/release/vc_redist.x64.exe)).

Чтобы запустить программу, откройте `AkashaScanner.exe`.
Программа запросит права Администратора,
которые необходимы для управления игрой.

Несколько важных настроек:__.
1. Язык игры должен быть английским
2. Окно игры должно быть не шире 16:9 и не меньше 1280x720
3. Во время сканирования весь экран игры должен оставаться видимым (не должно быть части за пределами экрана, и ничто не закрывает игровое окно).
4. Отключите все цветовые фильтры, такие как Reshade, Windows Night Light, F.lux, Nvidia Filters и Color-blind tools, которые могут быть запущены.

## Использование

Выберите сканер из левого меню.
Чтобы начать сканирование, следуйте инструкциям на странице.

Не используйте мышь или клавиатуру во время сканирования.
Сканер использует ввод данных с мыши и клавиатуры для автоматизации сканирования.

Если вы хотите прервать сканирование, вы можете свернуть или выйти из игры с помощью горячих клавиш Alt+Tab или Win+D.
Если вы прервете сканирование, имейте в виду, что весь прогресс будет потерян.


## FAQ

### Почему проект называется Akasha Scanner?
Цель этого проекта - предоставить игрокам возможность извлекать данные из игры
и делиться ими с другими инструментами, что напоминает
[внутриигровое устройство](https://genshin-impact.fandom.com/wiki/Akasha_System) 
которое передает и делится информацией.

### Будет ли мне запрещено игрой использовать сканер Акаша?
Скорее всего, нет, согласно [этой](https://genshin.hoyoverse.com/en/news/detail/5763) официальной статье.

Кроме того, аналогичные программы, такие как [Inventory Kamera](https://github.com/Andrewthe13th/Inventory_Kamera)
и [AdeptiScanner-GI](https://github.com/D1firehail/AdeptiScanner-GI)
существуют уже давно, и никому не было запрещено использовать эти приложения.

Однако нет никакой гарантии, что HoYoverse не предпримет никаких действий против сканера.
Используйте на свой страх и риск.

## Перевод
Ветку и софт перевёл: [ilfae](https://github.com/ilfae)
Данный софт перевёл для личного использования.

### Как работает сканер Akasha?
Он использует мышь и клавиатуру для навигации по вашим достижениям/персонажам/инвентарю,
и делать их скриншоты.

Для анализа скриншотов используется несколько методов.
Первая известна как [Оптическое распознавание символов (OCR)](https://en.wikipedia.org/wiki/Optical_character_recognition).
с использованием [Tesseract](https://github.com/tesseract-ocr/tesseract).
Он в основном используется для идентификации текста из изображений.
Например, таким образом определяются названия и уровни оружия/артефактов/персонажей.

Другие вещи, такие как подсчет количества звезд достижений/артефактов
используют распознавание объектов, предоставляемое [OpenCV](https://opencv.org).

### Насколько достоверны результаты сканирования?
Я бы сказал, что в настоящее время результаты довольно точные, но они не идеальны.

Например, распознавание числа `1` является довольно сложным для OCR,
особенно в уровнях талантов персонажей.
Кроме того, случайные снежинки, покрывающие имя и уровень персонажа, могут испортить OCR.

Использование более высокого разрешения значительно повысит точность.
Лично я использую разрешение 1920x1080, и оно работает достаточно хорошо.

### Могу ли я редактировать результат сканирования, если он неточный?
Я буду работать над этим в ближайшее время. Следите за новостями в новом релизе!

Пока что вы можете изменить JSON-файл в папке `ScannedData`.
Возможно, я подумаю о написании документа о схеме JSON-файла,
хотя я думаю, что они достаточно понятны.

### Как импортировать результаты сканирования на Paimon.moe/Seelie.me?
Сначала экспортируйте результаты сканирования в формат, совместимый с Paimon.moe/Seelie.me, используя Akasha Scanner.
Затем зайдите на сайт [Paimon.moe](https://paimon.moe/settings) или [Seelie.me](https://seelie.me/settings).
Выберите "Экспорт и импорт данных" и импортируйте файл, который вы только что экспортировали.

### У меня есть другие вопросы
Вы можете заглянуть на [this](https://github.com/xenesty/AkashaScanner/discussions) и поискать там ответы.
Если вы их не найдете, пожалуйста, не стесняйтесь начать новое обсуждение :)


## Возможные_обновления

Следующее - это просто список дел, которые я должен выполнить.

* [ ] Прерывание сканирования с помощью горячих клавиш
* [ ] Сканировать статус блокировки оружия и артефактов.
* [ ] Показывать захваченные скриншоты во время сканирования
* [ ] Снизить нагрузку на процессор при сканировании оружия и артефактов путем замены OCR на сопоставление шаблонов изображений
* [ ] Проверка отсканированных данных
* [ ] Просмотр отсканированных достижений
* [ ] Редактирование отсканированных достижений
* [ ] Просмотр отсканированных персонажей, артефактов и оружия
* [ ] Редактирование отсканированных персонажей, артефактов и оружия
* [ ] Сохранить незавершенное сканирование
* [ ] Добавить поддержку удаления отсканированных данных
* [ ] Добавить режим отладки
* [ ] Добавить поддержку сканирования материалов и материалов персонажей
* [ ] Добавить уведомление, когда нечего экспортировать
* [ ] Сделать главную страницу лучше, чем текущая.
* [ ] Нужна лучшая иконка


## Вклад

Любой вклад приветствуется!

### Сообщение_об_ошибках

Если вы столкнулись с каким-либо странным поведением при использовании сканера Akasha,
не стесняйтесь открыть новую проблему в этом репозитории.
Пожалуйста, выполните поиск, прежде чем открывать новую проблему,
чтобы убедиться, что никто еще не сообщил или не решил найденную вами ошибку.

Пожалуйста, предоставьте как можно больше информации,
например, файлы журналов (в директории `Logs`),
конфигурации вашей системы (разрешение окна игры и разрешение вашего монитора)
и/или скриншоты вашей игры
(__убедитесь, что вы стерли свой UID в правом нижнем углу!__)

### Отправка_запросов_на_исправление
Все запросы на исправление очень ценятся.
Вы можете взглянуть на
[открытые проблемы](https://github.com/xenesty/AkashaScanner/issues?q=is%3Aopen+is%3Aissue)
если вы ищете, с чего начать.

У меня также нет большого опыта работы с C# и .NET Core
(на самом деле, это мой первый раз, когда я пишу на C#).
Так что если я сделал что-то глупое, пожалуйста, укажите на это.

(Также мне нужна помощь в исправлении моего английского >.<)


## Благодарности

Выражаю благодарность [Inventory Kamera](https://github.com/Andrewthe13th/Inventory_Kamera) за вдохновение в работе.


## Лицензия
[![Лицензия: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/xenesty/AkashaScanner/blob/master/LICENSE.txt)
