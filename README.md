HoloLens 2 のAppDataにテキストを書き込み、デバイスポータルで参照する

# 環境
- Unity 2019.4.22f1
- MixedRealityFeatureTool-1.0.2103.2- Beta
- MRTK 2.6.0

# 概要

- HoloLens 2でテキストファイルを書き込み、デバイスポータルでダウンロードする

# AppDataにテキストデータを保存するC#のコード

- Application.persistentDataPath でパスを取得する

```
var path = Application.persistentDataPath + "\\my_file.txt";
using (StreamWriter sw = File.AppendText(path))
{
    string s = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    sw.WriteLine(s);
}
```

# 保存先のパス

```
C:\Data\Users\{USER_NAME}\AppData\Local\Packages\{APP_NAME}_{ID}\LocalState
```

# 応用

- デバイスポータルからアップロードしたファイルを、HoloLens 2 で読み込むこともできる

# 用途

- アプリケーションの動作ログの保存（UnityのDebug.Logは、Debugビルドに時間がかかる＆処理負荷が高い）
- 設定ファイルの読み込み