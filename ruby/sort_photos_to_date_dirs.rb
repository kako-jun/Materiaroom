# -*- coding: utf-8 -*-

require 'kconv'
require 'fileutils'

class SortPhotosToDateDirs
  def initialize()
  end

  def run( *args )
    # 引数をチェック
    if ARGV.size == 0 || ARGV.size > 2 then
      puts 'Usage: ' + $PROGRAM_NAME + ' [src_dir_path] ([dst_dir_path])'
      exit
    end

    # -U 付きで実行すると、引数はUTF8になっている
    src_dir_path = ARGV[0]
    #dst_dir_path = File.expand_path( File.dirname( __FILE__ ) )
    dst_dir_path = src_dir_path
    dst_dir_path = ARGV[1] if ARGV.size >= 2

    src_dir_path = src_dir_path.gsub( '\\', '/' )
    dst_dir_path = dst_dir_path.gsub( '\\', '/' )

    file_count = 0
    done_count = 0
    #files = Dir::entries( src_dir_path )
    # 再帰的にする
    # globはSJISしか受け付けない
    file_paths = Dir.glob( src_dir_path.kconv( Kconv::SJIS, Kconv::UTF8 ) + '/' + '**/*' )

    file_paths.sort!

    # 総数を計算する
    total = 0
    file_paths.each do |file_path|
      # 「～」などが含まれていると、例外が発生する
      fileType=  ''
      begin
        fileType = File.ftype( file_path )
      rescue
        # Do nothing.
      end

      if fileType == 'file' then
        total += 1
      end
    end

    # メインループ
    file_paths.each do |file_path|
      # basenameはSJISしか受け付けない
      file = File.basename( file_path.kconv( Kconv::SJIS, Kconv::UTF8 ) )
      file = file.kconv( Kconv::UTF8, Kconv::SJIS )

      # 「～」などが含まれていると、例外が発生する
      fileType=  ''
      begin
        fileType = File.ftype( file_path )
      rescue
        puts '[' + file_count.to_s + ' / ' + total.to_s + ']'
        puts  '- Skip unsupported path: ' + file
        puts ''
        next
      end

      if fileType == 'file' then
        file_count += 1

        fileBk = file.clone

        # 小文字にする
        downFile = file.downcase

        # 「desktop.ini」、「.picasa.ini」、「thumbs.db」などは対象外
        if downFile =~ /\.ini$/ || downFile =~ /\.db$/ || downFile =~ /^\./ then
          puts '[' + file_count.to_s + ' / ' + total.to_s + ']'
          puts  '- Skip unsupported file: ' + file
          puts ''
          next
        end

        # 拡張子を取得する
        ext = File.extname( file ).downcase

        file = File.basename( file, ext ).downcase

        # YYYY_MM_DD、YYYY.MM.DDだったら、YYYY-MM-DDにする
        file.sub!( /^(\d{4})_(\d{2})_(\d{2})(.*$)/, '\1-\2-\3\4' )
        file.sub!( /^(\d{4})\.(\d{2})\.(\d{2})(.*$)/, '\1-\2-\3\4' )
        # YYYY-MM-DD-、YYYY-MM-DD だったら、YYYY-MM-DD_にする
        file.sub!( /^(\d{4}-\d{2}-\d{2})-(.*$)/, '\1_\2' )
        file.sub!( /^(\d{4}-\d{2}-\d{2})\s(.*$)/, '\1_\2' )
        # HH_MM_SS、hh.mm.ssだったら、hh-mm-ssにする
        file.sub!( /(^.*_)(\d{2})_(\d{2})_(\d{2})(.*$)/, '\1\2-\3-\4\5' )
        file.sub!( /(^.*_)(\d{2})\.(\d{2})\.(\d{2})(.*$)/, '\1\2-\3-\4\5' )

        new_dir_path = ''

        # YYYY-MM-DD形式か確認
        if file[0, 10] !~ /^(\d{4})-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$/ then
          # Exifなし。日付なし
          #puts  '- DateTime not found in file name: ' + file
          new_dir_path = dst_dir_path + '/' + 'etc'
          file = fileBk
        else
          # 月、日の文字列を取得
          day = file[0, 10]
          month = file[0, 7]
          new_dir_path = dst_dir_path + '/' + month + '/' + day
          file = file + ext
        end

        # 分類先のディレクトリがなかったら作る
        # mkdirはSJISしか受け付けない
        FileUtils.mkdir_p( new_dir_path.kconv( Kconv::SJIS, Kconv::UTF8 ) ) unless FileTest.exist?( new_dir_path )

        new_file_path = new_dir_path + '/' + file

        # ファイル更新日時を上書きしない
        if File.exist?( new_file_path ) then
          puts '[' + file_count.to_s + ' / ' + total.to_s + ']'
          puts '- Skip file already exists: ' + new_file_path
          puts ''
        else
          begin
            # 入力パス、出力パスに日本語を含む場合は、未対応
            # copyの第２引数は、UTF8しか受け付けない
            FileUtils.copy( file_path, new_file_path, { :preserve => true, :verbose => true } )
          rescue
            # Do nothing.
          end

          # コピーできたか
          if FileTest.exist?( new_file_path ) then
            puts ''
            puts '[' + file_count.to_s + ' / ' + total.to_s + ']'
            puts '- Copy to: ' + new_file_path
            puts ''
          else
            puts ''
            puts '[' + file_count.to_s + ' / ' + total.to_s + ']'
            puts '- Skip unsupported file: ' + file
            puts ''
          end

          done_count += 1
        end
      end
    end

    puts '-' * 20
    puts 'Done: ' + done_count.to_s + ' file(s).'
    puts 'Skip: ' + ( file_count - done_count ).to_s + ' file(s).'

    # コマンドプロンプトを残すため
    puts ''
    puts 'Press any key ...'
    STDIN.gets
  end
end

inst = SortPhotosToDateDirs.new
inst.run

