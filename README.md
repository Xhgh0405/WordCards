# WordCards / TSVFile 完整實作

這份壓縮檔依照 `07_wordcards_114-2_0520.pdf` 實作兩個 Windows Forms 專案：

1. `WordCards`：單字卡主程式
2. `TSVFile`：TSV 資料檔讀取程式

## 已實作功能

### WordCards

- 讀取 `WordCards.txt`
- 左側顯示單字清單
- 顯示單字、音標、解釋
- 播放 `Sound/A/*.mp3` 單字發音
- `Play / Stop` 自動播放，Timer 間隔 2000 ms
- `上一個` 按鈕：往前一個單字並播放
- `下一個` 按鈕：往後一個單字並播放
- `Enter` 下一個單字
- `Backspace` 上一個單字
- `Space` 重播目前單字
- 點選單字會顯示並播放
- 雙擊單字可開啟編輯視窗
- 編輯後會存回 `WordCards.txt`
- 保留原始 Unicode / UTF-16 單字檔格式，音標可正常顯示
- 已加上簡單美編：上方藍色標題列、中文字體、按鈕配色、左側清單底色、解釋區塊框線與提示文字

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
