# -*- coding: utf-8 -*-

require 'kconv'
require 'fileutils'
require 'exifr'

class RenameByExif
  def initialize()
  end

  def run( *args )
    # 引数をチェック
    if ARGV.size == 0 || ARGV.size > 2 then
      babel()
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

        new_dir_path = ''

        # Exif情報を元にリネームする
        begin
          exif = EXIFR::JPEG.new( file_path )
          file =  exif.date_time.strftime( '%Y-%m-%d_%H-%M-%S' ) + ext
          new_dir_path = dst_dir_path
        rescue
          if ext == '.avi' || ext == '.mov' then
            begin
              file =  File.mtime( file_path ).strftime( '%Y-%m-%d_%H-%M-%S' ) + ext
              new_dir_path = dst_dir_path
            rescue
              new_dir_path = dst_dir_path + '/' + 'etc'
            end
          else
            new_dir_path = dst_dir_path + '/' + 'etc'
          end
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
            puts '- Rename to: ' + new_file_path
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

  def babel()
    system( 'cls' )
    system( 'color C' )
    print 'BABEL ' * 1000

    100.times do
      print 'BABEL '
      sleep( 0.01 )
    end

    system( 'cls' )
    system( 'color F' )
  end
end

inst = RenameByExif.new
inst.run

