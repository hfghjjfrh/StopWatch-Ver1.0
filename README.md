# StopWatch アプリ解説

## 概要

この C# コードは、Windows Forms を使ったシンプルなストップウォッチアプリです。

* スタート、ストップ、リセットボタン
* 時間を HH:MM:SS 形式で表示
* プログレスバー表示
* サウンド再生（ファイルが存在しない場合はエラーメッセージ表示）

---

## 1. フィールドとコンストラクタ

```csharp
Timer _timer1 = new Timer();
TimeSpan _timespan = new TimeSpan(0);
DateTime sn = DateTime.Now;
```

* `_timer1`：タイマー用
* `_timespan`：累積時間保持用
* `sn`：タイマー開始時刻

### コンストラクタ

```csharp
public StopWatch()
{
    InitializeComponent();
    _timer1.Interval = 100;
    _timer1.Tick += timer1_tick;
    Start.Enabled = true;
    Stop.Enabled = false;
    Status.Minimum = 0;
    Status.Maximum = 0;
    Status.Value = 0;
}
```

* タイマー間隔は 100ms
* ボタンとプログレスバーの初期化

---

## 2. タイマー更新処理

```csharp
private void timer1_tick(object sender, EventArgs e)
{
    TimeSpan timespan = DateTime.Now - sn + _timespan;
    display.Text = string.Format("{0:00}:{1:00}:{2:00}", timespan.Hours, timespan.Minutes, timespan.Seconds);
}
```

* `_timer1` の Tick イベントで呼び出される
* 累積時間を加算して HH:MM:SS 形式で表示

---

## 3. スタートボタン

```csharp
private void Start_Click(object sender, EventArgs e)
{
    Start.Enabled = false;
    Stop.Enabled = true;
    try
    {
        SoundPlayer simpleSound = new SoundPlayer(@"..\..\sound\chimes.wav");
        simpleSound.Play();
    }
    catch(System.IO.FileNotFoundException)
    {
        MessageBox.Show("サウンドファイルが見つかりません。", "エラー");
    }
    _timer1.Start();
    sn = DateTime.Now;
    Status.Style = ProgressBarStyle.Marquee;
    Status.Maximum = 10;
    Status.MarqueeAnimationSpeed = 30;
}
```

* タイマー開始、ボタン状態変更
* サウンド再生は `try-catch` で安全に処理
* プログレスバーを Marquee スタイルに変更

---

## 4. ストップボタン

```csharp
private void Stop_Click(object sender, EventArgs e)
{
    try { /* SoundPlayer */ } catch { /* エラー処理 */ }
    Start.Enabled = true;
    _timer1.Stop();
    _timespan += DateTime.Now - sn;
    Stop.Enabled = false;
    Status.MarqueeAnimationSpeed = 0;
}
```

* タイマー停止、累積時間加算
* ボタン状態を戻す
* プログレスバーのアニメーション停止

---

## 5. リセットボタン

```csharp
private void Reset_Click(object sender, EventArgs e)
{
    try { /* SoundPlayer */ } catch { /* エラー処理 */ }
    Start.Enabled = true;
    Stop.Enabled = false;
    Status.Minimum = 0;
    Status.Maximum = 0;
    Status.Value = 0;
    _timer1.Stop();
    _timespan = new TimeSpan(0);
    sn = DateTime.Now;
    display.Text = string.Format("{0:00}:{1:00}:{2:00}", _timespan.Hours, _timespan.Minutes, _timespan.Seconds);
}
```

* タイマー停止、累積時間リセット
* プログレスバーリセット
* 表示を 00:00:00 に戻す

---

## 6. サウンド再生と例外処理

* `SoundPlayer` を使用して WAV ファイル再生
* ファイルが存在しない場合は `FileNotFoundException` をキャッチして MessageBox で通知
* `..\..\sound\` は実行ファイルから 2つ上のディレクトリを参照

---

## まとめ

* Windows Forms で簡単にストップウォッチを作成可能
* タイマーは `Timer` と `Tick` イベントで制御
* サウンド再生は `try-catch` で安全に実装
* プログレスバーで視覚的に状態を表示
