# 圖書管理程式 Book Management System

本專案是一個使用 C# Windows Forms 製作的圖書管理程式，主要練習 `ListView` 清單檢視控制項的使用。  
使用者可以透過不同檢視模式瀏覽書籍，並且可以透過雙擊書籍將書本加入借書清單。

---

## 專案畫面截圖

### 主畫面

請將程式主畫面截圖放在 `screenshots/main.png`

<img width="295" height="260" alt="螢幕擷取畫面 2026-05-19 101712" src="https://github.com/user-attachments/assets/0017bea0-8bb3-4cbe-a209-7b541e12a26d" />
<img width="778" height="442" alt="螢幕擷取畫面 2026-05-19 101741" src="https://github.com/user-attachments/assets/8a5bf481-2cfc-48c7-b783-ad5a63f64216" />


---

### 大圖示檢視

請將大圖示模式截圖放在 `screenshots/large-icon.png`

![大圖示檢視](screenshots/large-icon.png)

---

### 詳細資料檢視

請將詳細資料模式截圖放在 `screenshots/details-view.png`

![詳細資料檢視](screenshots/details-view.png)

---

### 借書功能畫面

請將借書確認或借書清單畫面截圖放在 `screenshots/borrow-list.png`

![借書功能畫面](screenshots/borrow-list.png)

---

## 功能介紹

本程式包含以下功能：

- 顯示多本書籍資料
- 每本書包含書名、作者、類別
- 使用 `ListView` 顯示書籍
- 支援多種檢視模式
  - 大圖示
  - 詳細資料
  - 小圖示
  - 清單
  - 大圖示加詳細資料
- 使用者可以雙擊書籍進行借閱
- 借閱前會跳出確認視窗
- 已借閱的書會顯示在右側借書清單
- 同一本書不可重複借閱
- 程式啟動時會顯示使用說明
- 按下 F1 可以再次查看使用說明

---

## 使用技術

- C#
- Windows Forms
- ListView
- ComboBox
- ListBox
- ImageList
- MessageBox

---

## 程式介面說明

| 控制項 | 名稱 | 功能 |
|---|---|---|
| ListView | `lvwBooks` | 顯示書籍清單 |
| ComboBox | `cmbView` | 切換書籍檢視方式 |
| ListBox | `lstBorrow` | 顯示已借閱書籍 |
| ImageList | `imgL` | 儲存大圖示圖片 |
| ImageList | `imgS` | 儲存小圖示圖片 |
| Panel | `pnlTools` | 右側工具區 |
| GroupBox | `grpView` | 檢視方式區塊 |
| GroupBox | `grpBorrow` | 借書清單區塊 |

---

## 書籍資料

程式目前內建以下書籍：

| 書名 | 作者 | 類別 |
|---|---|---|
| 三國演義 | 羅貫中 | 章回小說 |
| 西遊記 | 吳承恩 | 章回小說 |
| 唐詩三百首 | 孫洙 | 詩選 |
| 楚辭 | 劉向 | 詩歌 |
| 西廂記 | 王實甫 | 戲曲 |
| 水滸傳 | 施耐庵 | 章回小說 |
| 紅樓夢 | 曹雪芹 | 章回小說 |
| 牡丹亭 | 湯顯祖 | 戲曲 |

---

## 使用方法

1. 開啟程式後，左側會顯示所有書籍。
2. 使用右上方的「檢視方式」下拉選單切換顯示模式。
3. 在左側書籍上按兩下，即可進行借閱。
4. 系統會跳出確認視窗，詢問是否確定借閱。
5. 按下「是」後，該書會加入右側借書清單。
6. 若同一本書已經借過，系統會顯示提醒訊息。
7. 按下鍵盤 F1，可以再次查看使用說明。

---

## 如何執行專案

1. 使用 Visual Studio 開啟專案。
2. 確認專案類型為 Windows Forms App。
3. 開啟 `frmBooks.cs`。
4. 確認控制項名稱如下：

```text
lvwBooks
cmbView
lstBorrow
imgL
imgS
pnlTools
grpView
grpBorrow
