using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Final
{
    public enum file_types { raw_text, json, binary}
    class fileOutput
    {
        
        public string File_Path { get; }
        public file_types File_Type { get; set; }
        public fileOutput(string File_Path, file_types File_type)
        {
            this.File_Path = File_Path;
            this.File_Type = File_Type;

            if(this.File_Type == file_types.json && !this.File_Path.EndsWith(".json"))
            {
                this.File_Path += ".json";
            }

            if(this.File_Type == file_types.binary && this.File_Path.Contains("."))
            {
                this.File_Path = this.File_Path.Remove(this.File_Path.IndexOf('.'), this.File_Path.Length - this.File_Path.IndexOf('.'));
            }

            // TODO: this is for the file path dummy
            //if (File.Exists(File_Path))
            //{
            //    this.File_Path = File_Path;
            //}
            //else if(File.Exists(@"..\..\..\" + File_Path))
            //{
            //    this.File_Path = @"..\..\..\" + File_Path;
            //}
            //else
            //{
            //    this.File_Path = ""
            //}
        }
        public void Write(object[] class_data)
        {
            switch (this.File_Type)
            {
                case file_types.raw_text: this.Raw_Text(class_data); break;
                case file_types.json: this.Json(class_data); break;
                case file_types.binary: this.Binary(class_data); break;
            }
        }

        private void Binary(object class_data)
        {
            // I can't write an array of objects so it has been scrapped
            object[] objects;
            if (File.Exists(this.File_Path))
            {
                BinaryReader binary_file = new BinaryReader(new FileStream(this.File_Path, FileMode.Open, FileAccess.Read));
                byte[] byte_array = binary_file.ReadBytes((Int32)new FileInfo(this.File_Path).Length);
                MemoryStream memoryStream = new MemoryStream(byte_array);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                memoryStream.Position = 0;
                object[] temp = (object[])binaryFormatter.Deserialize(memoryStream);
                objects = new object[temp.Length];

                for(int i = 0; i < temp.Length; i++)
                {
                    objects[i] = temp[i];
                }
            }
            else
            {
                objects = new object[1];
            }

            objects[objects.Length - 1] = class_data;


            using (BinaryWriter binWriter = new BinaryWriter(File.Open(this.File_Path, FileMode.CreateNew)))
            {
                binWriter.Write(1 /*objects*/);
            }


        }

        private void Raw_Text(object[] vs)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(this.File_Path))
            {
                foreach(var i in vs)
                {
                    file.WriteLine(i.ToString());
                }
            }
        }

        

        private void Json(object[] x)
        {
            string json = JsonConvert.SerializeObject(x);
            File.WriteAllText(this.File_Path, json);
        }

        
        
    }
}
