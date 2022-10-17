# Лабораторна робота №1. Основи роботи з [ASP.NET](http://ASP.NET) Core MVC

------------------------------
Тема: Розклад Руху автобусів
Сайт аналог:

Team Lead - Даніель Демчук
Developer - Ілля Гупалюк
------------------------------

## 🎯 **Мета**

Метою лабораторної роботи є вивчення основ архітектури проєктів на [ASP.NET](http://ASP.NET) Core,
життєвого циклу сторінки та принципів роботи Model-View-Controller, а також базових принципів колективної роботи у ІТ.

⚠️ Робота може бути також виконана індивідуально, колективне виконання не є обов’язковою умовою.
    Але врахуйте, що наступні лабораторні роботи базуватимуться на попередній, тому колективи працювать разом до кінця курсу.


## ✍️ **Завдання**

- Обрати тему.
- Cформувати групу (2 максимум, поки вистачить) або прийняти рішення про індивідуальне виконання.
*Примітка. Дедлайн затвердження теми **14:00 17 жовтня.**
Зверніть увагу, що тему може також запропонувати і студент, не обов’язково обирати з даного переліку.*
- Визначити ролі у проєкті: `Team Lead`, `Developer`.
- Обрати сайт-аналог, з якого братиметься орієнтовна структура БД.
- Розділити завдання на підзадачі (скласти чіткий список).
- Розподілити задачі між учасниками виконання проєкту.
- Створити репозиторій на `github`/ `bitbucket` / `azure devops` тощо.
- Запросити учасників команди.
- Кожну задачу виконує визначений учасник у окремій гілці, `Team Lead` робить `merge` у `main`.
- Підготовка звіту.
- Публічний захист.

⚠️ *Примітка. Захист роботи може тривати не більше 7-ми хвилин.
    Підготуйтеся до захисту, розподіліть між учасниками групи черговість виступу та матеріал.
    Перевірте чи вистачає часу на запланований матеріал.*


## 📄 Структура звіту

1. Титульна сторінка.
2. Зміст.
3. Опис завдання.
4. Опис ролей учасників та їх завдань.
5. Опис користувачів системи.
6. Структура бази даних (блок схема + пояснення чому саме такі типи зв’язків).
7. Опис графічного інтерфейсу.

---


## ⏳ Дедлайни здачі

Затвердження теми: до 14:00 17 жовтня
Завантаження у Moodle лінка на репозиторій та звіту: ___

---

## 🏅 Оцінювання (20 балів)
📎 Захист відбувається і зараховується лише за умови присутності обох учасників проєкту (якщо він виконувався у групі).
  Оцінка ставитиметься 1 на 2-х учасників, тому підбирайте колег, що зможуть успішно захищати проєкт, а не бути “баластом” 🙂.


| Види робіт                               | Оцінка |

| Якість підготовки звіту                    | 4 |
| Відповідність завдання результату          | 5 |
| Колективна робота (github будемо дивитися) | 3 |
| Терміни захисту (до 7 хв. на групу)
(відповіді на запитання не входять у час)    | 3 |
| Відповіді на запитання                     | 5 |

---

⚠️ Увага. Базу даних потрібно описати якнайближче до потрібної у реальних умовах,
    то варто вивчити один із сайтів схожої тематики і намагатися повторити наповення.
    Наприклад, якщо це “Каталог автомобілів” (обираємо для прикладу сайт `auto.ria`),
    то ми повинні у БД мати інформацію про марку, модель, стан, тип палива, рік випуску, колір, фото та інше. При цьому марка, модель,
    типа палива є окремими сутностями.
    Відповідність спроєктованій БД є одним із завдань, яке також буде оцінюватися.

**У проєкті повинна бути реалізована система авторизації та реєстрації користувачів та їх розділення на ролі
  (наприклад, Адміністратор, Модератор, Покупець).**
