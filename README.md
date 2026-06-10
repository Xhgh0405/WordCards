# WordCards
## 專案簡介

本專案為一套以英文字卡學習為核心的 Windows Forms 應用程式，包含「WordCards」與「TSVFile」兩個子系統。WordCards 提供單字瀏覽、音標顯示、中文解釋與發音播放功能，並支援鍵盤操作、自動播放及單字編輯，提升學習互動性與效率；TSVFile 則作為資料檢視工具，可開啟並解析 TSV 檔案，將單字相關資訊以表格方式呈現。

本系統整合檔案讀寫、使用者介面設計、多媒體播放與事件控制等技術，實現一個兼具學習與資料管理功能的桌面應用程式。

## 已實作功能&執行說明

### WordCards

- 讀取 `WordCards.txt`
- 左側顯示單字清單
- 顯示單字、音標、解釋
<img width="852" height="488" alt="image" src="https://github.com/user-attachments/assets/c2b2002f-fbf3-4f0f-8ff7-8e46ef5f8bba" />

- 播放 `Sound/A/*.mp3` 單字發音
- `Play / Stop` 自動播放，Timer 間隔 2000 ms
- `上一個` 按鈕：往前一個單字並播放
- `下一個` 按鈕：往後一個單字並播放
- `Enter` 下一個單字
- `Backspace` 上一個單字
- `Space` 重播目前單字
- 點選單字會顯示並播放
- 雙擊單字可開啟編輯視窗
<img width="842" height="496" alt="image" src="https://github.com/user-attachments/assets/826128ac-e069-46dc-941f-5970a91b5cf4" />
- 編輯後會存回 `WordCards.txt`

- 保留原始 Unicode / UTF-16 單字檔格式，音標可正常顯示
- 已加上簡單美編：上方藍色標題列、中文字體、按鈕配色、左側清單底色、解釋區塊框線與提示文字
  改過的截圖畫面
<img width="850" height="484" alt="image" src="https://github.com/user-attachments/assets/459e2650-eb0e-4dbe-86c6-9d39e7ee50be" />


### TSVFile

- File / Open 開啟 `.tsv`、`.txt` 檔案
- ListView 顯示「單字、音標、音檔路徑、解釋」四欄
- Help / About 顯示關於視窗
- Exit 與視窗關閉時會詢問是否離開

## 使用方式

1. 解壓縮後用 Visual Studio 2022 開啟：
   `WordCards_FullSolution.sln`
2. 右鍵 `WordCards` 或 `TSVFile` → 設為啟始專案。
3. 建置並執行。

## 注意

`WordCards` 使用 Windows Media Player COM 元件播放 mp3。若你的 Visual Studio 顯示 WMPLib 參考錯誤，請在 `WordCards` 專案按右鍵：

`加入參考` → `COM` → 勾選 `Windows Media Player`。
