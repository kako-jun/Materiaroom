================================================================================
# ／Materiaroom マテリアルーム／
================================================================================
このファイルを開いてくれてありがとう。

Materiaroomは、いわゆる写真の自動リネームツールです。
しかし、「ファイル名を細かく設定できる」一般的なツールと異なり、
「たった１つの命名ルール」に特化しています。

具体的には、
「2013-03-24_12-34-56.jpg」
のような、日付＋時刻の形式にリネームされます。

さらに、
「2013-03」、「2013-03-24」のように、月、日のフォルダが自動的に作られ、
「2013-03-24_12-34-56.jpg」は、その中にコピーされます。

入力として複数のフォルダを指定すると、含まれるすべての写真に対し、
上記のルールでのリネーム、フォルダ分けが実行されます。

- シンプルなリネームツールがほしい
- 未整理の写真に埋もれている
- 複数のカメラで撮った写真が別々のフォルダにあり、統合が面倒

な人にとって、強力な味方になるでしょう。

ほか、以下の機能も持っています。

- 前回使った入力フォルダ、出力フォルダを覚えてるので、起動してボタンを押すだけ
- 移動機能は怖すぎるので、敢えて付けない。コピーのみ！
- Exif情報（撮影日付など）が含まれてないファイルも、etcフォルダに余さずコピー
- リネーム後のファイルを、好きな外部ツールに送る機能

--------------------------------------------------------------------------------
# インストール方法
--------------------------------------------------------------------------------
「Materiaroom.zip」を解凍するだけです。

「.NETがない」系のエラーが出た場合は、先に
http://www.microsoft.com/ja-jp/download/details.aspx?id=24872
からインストールしてください。

--------------------------------------------------------------------------------
# アンインストール方法
--------------------------------------------------------------------------------
ゴミ箱にポイするだけです。

--------------------------------------------------------------------------------
# 使い方
--------------------------------------------------------------------------------
なんとなくでも使えますが、詳しい使い方、応用例は、
Googleで「materiaroom jpico 使い方」を検索してください。
公式サイトでの画像付き解説が出てきます。

--------------------------------------------------------------------------------
# インストールされるファイルの説明
--------------------------------------------------------------------------------
Materiaroom.zip
├ Readme-はじめにお読みください.txt
├ Readme_en.txt
├ Materiaroom.exe
├ rename_by_exif.exe
├ sort_photos_to_date_dirs.exe
├ materiaroom_setting_ja.xml
├ materiaroom_setting_en.xml
├ ja/
└ ruby/

- Readme-はじめにお読みください.txt
いま開かれているファイルです。

- Readme_en.txt
説明書の英語版です。英語に強い人の添削希望。

- Materiaroom.exe
ツールの実行ファイル本体です。

- rename_by_exif.exe
- sort_photos_to_date_dirs.exe
ツールを構成する、その他の実行ファイルです。

- materiaroom_setting_ja.xml
- materiaroom_setting_en.xml
設定ファイルです。

- ja/
日本語化用のファイルです。

- ruby/
exe化する前のrubyスクリプトです。
Windows以外でも利用できます。

--------------------------------------------------------------------------------
# 環境
--------------------------------------------------------------------------------
- 動作環境: Windows XP以降（要.NET Framework 4.0）
- 開発環境: Windows 8 / VS Express 2012 / .NET Framework 4.0 / C# / Ruby 1.9.2

--------------------------------------------------------------------------------
# 著作権について
--------------------------------------------------------------------------------
このツールは「同人ゲーム製作サークル Ｊピコ」が作ったので、著作権は
サークルに帰属します。

常識的であれば、利用に制限は設けません。
気軽に使ってもらったほうが、ツールも喜びます。
ソースも公開予定です。

- 個人での利用: OK
- 企業での利用: OK
- 同人サークルでの利用: むしろ歓迎
- 紹介: zipへの直リンク、サイトや紙への掲載、全部OK
- 再配布: zipのプレゼント、他サーバへのアップロード、メールでの受け渡し、全部OK
- 自分が作ったと嘘をつくこと: NG
- 有償で再配布すること: NG
- ソースを元に機能を追加するなど、自分のアプリとして作り変えること: OK
- そのアプリを他者に公開して稼ぐこと: アプリ名を変えればOK

矢印屋
http://yajirushiya.netgamebm.com

lcons by FatCow Web Hosting
Creative Commons Attribution 3.0 license
http://www.fatcow.com/free-icons

                                                      Copyright (c) Jpico 2013 -
--------------------------------------------------------------------------------
# 免責
--------------------------------------------------------------------------------
万一損害が生じても、責任を負えません。ご了承ください。

--------------------------------------------------------------------------------
# 公式サイトのご案内
--------------------------------------------------------------------------------
「同人ゲーム製作サークル Ｊピコ 公式サイト」があります。

- 自分のOSで動かないんだがッ！
- エラーを吐いて消えた！
- こんな使い方を思いついてしまった……！

など、情報共有してもらえるとツールも喜びます。
                                                              https://jpico.info
--------------------------------------------------------------------------------
# 更新履歴
--------------------------------------------------------------------------------
- 2013/03/27: 初回リリース
- 2013/04/08: avi, movを更新日時でリネームする機能を追加

--------------------------------------------------------------------------------
                                   ＜○√
                                     ‖
                                    くく

