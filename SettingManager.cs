using System.Text.Json.Nodes;

namespace SoundRecorder
{
    internal class SettingManager
    {
        public enum SaveFormat {Wav=0,Mp3 }
        public enum SaveTo { ChipBoard=0, File }
        public static readonly string SettingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.json");
        private static SettingManager mInstance;
        public static SettingManager Instance { get 
            {
                if (mInstance == null)
                    mInstance = new SettingManager();
                return mInstance;
            } 
        }

        private SettingManager()
        {
            if (!File.Exists(SettingPath)) File.WriteAllText(SettingPath, "{ }");
        }

        private JsonNode GetProperty(string key)
        {
            lock (this)
            {
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    return obj[key];
                }
            }
        }



        public class Editor
        {
            private JsonNode _Temp;
            private SettingManager SettingManager;
            public Editor(SettingManager manager,string json)
            {
                _Temp = JsonNode.Parse(json);
                this.SettingManager = manager;
            }

            public void Commit()
            {
                lock (SettingManager)
                {
                    File.WriteAllText(SettingPath, _Temp.ToJsonString());
                }
                
            }

            public void Set(string key,string value)
            {
                _Temp[key] = value;
            }
            public void Set(string key, int value)
            {
                _Temp[key] = value;
            }
            public void Set(string key, long value)
            {
                _Temp[key] = value;
            }
            public void Set(string key, double value)
            {
                _Temp[key] = value;
            }
        }

        
        public Editor Edit()
        {
            lock (this)
            {
                return new Editor(this,File.ReadAllText(SettingPath));
            }
            
        }

        public void Set(string key,int value)
        {
            lock (this)
            {
                string output;
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    obj[key] = value;
                    output = obj.ToJsonString();
                }
                File.WriteAllText(SettingPath, output);
            }
        }

        public void Set(string key, long value)
        {
            lock (this)
            {
                string output;
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    obj[key] = value;
                    output = obj.ToJsonString();
                }
                File.WriteAllText(SettingPath, output);
            }
        }

        public void Set(string key, float value)
        {
            lock (this)
            {
                string output;
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    obj[key] = value;
                    output = obj.ToJsonString();
                }
                File.WriteAllText(SettingPath, output);
            }
        }

        public void Set(string key, double value)
        {
            lock (this)
            {
                string output;
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    obj[key] = value;
                    output = obj.ToJsonString();
                }
                File.WriteAllText(SettingPath, output);
            }
        }

        public void Set(string key, string value)
        {
            lock (this)
            {
                string output;
                using (Stream stream = File.OpenRead(SettingPath))
                {
                    JsonNode obj = JsonNode.Parse(stream);
                    obj[key] = value;
                    output = obj.ToJsonString();
                }
                File.WriteAllText(SettingPath, output);
            }
        }


        public T Get<T>(string key,T deafult)
        {
            JsonNode node;
            if ((node = GetProperty(key)) != null)
                return node.GetValue<T>();
            return deafult;
        }




    }
}
