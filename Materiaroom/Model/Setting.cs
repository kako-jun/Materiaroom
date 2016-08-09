using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Materiaroom
{
    public class Setting
    {
        public string exifPath { get; set; }
        public string dirPath { get; set; }
        public string toolPath { get; set; }
        public int level { get; set; }

        public enum Kind
        {
            Exif,
            Dir,
            Tool,
        };

        public Setting()
        {
            exifPath = "";
            dirPath = "";
            toolPath = "";
            level = 0;
        }

        private static string file_name = "materiaroom_setting_" + Materiaroom.Properties.Resources.Lang + ".xml";

        public bool save()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\" + file_name;

            XmlSerializer serializer = new XmlSerializer(typeof(Setting));
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                serializer.Serialize(fs, this);
                fs.Close();

                // たまにファイル末尾が化けることがあるため
                string text = File.ReadAllText(path, Encoding.GetEncoding("utf-8"));
                int find = text.IndexOf("</Setting>");
                text = text.Substring(0, find);
                text += "</Setting>";

                File.WriteAllText(path, text, Encoding.GetEncoding("utf-8"));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool load()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\" + file_name;
            Setting tempSetting = new Setting();

            XmlSerializer serializer = new XmlSerializer(typeof(Setting));
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                tempSetting = (Setting)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {
                return false;
            }

            this.exifPath = tempSetting.exifPath;
            this.dirPath = tempSetting.dirPath;
            this.toolPath = tempSetting.toolPath;
            this.level = tempSetting.level;

            return true;
        }
    }
}
