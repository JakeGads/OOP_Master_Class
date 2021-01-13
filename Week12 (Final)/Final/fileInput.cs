using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Final
{
    class fileInput
    {
        private string File_Name;

        public fileInput(string File_Name)
        {
            this.File_Name = File_Name;
        }

        public List<object> Parse()
        {
            if (this.File_Name.Contains(".json"))
            {
                return this.Json();
            }
            else
            {
                return this.Raw();
            }
        }

        private List<object> Raw()
        {
            List<object> items = new List<object>();

            if (File.Exists(this.File_Name))
            {
                using (StreamReader r = new StreamReader(this.File_Name))
                {
                     foreach(var file in r.ReadToEnd())
                     {
                        foreach(var line in file.ToString().Split("\n"))
                        {
                            var data = line.Split("|");

                            switch (data.Length)
                            {
                                case 3: items.Add(new baseEmployee(data[0], data[1], data[2])); break;
                                case 5: items.Add(new advancedEmployee(data[0], data[1], data[2], Double.Parse(data[3]), Double.Parse(data[4]))); break;
                                case 7:
                                    var level = data[5];
                                    permission_level i;
                                    if (level.Equals("low"))
                                    {
                                        i = permission_level.low;
                                    }
                                    else if (level.Equals("meduim"))
                                    {
                                        i = permission_level.meduim;
                                    }
                                    else // if (level.Equals("high"))
                                    {
                                        i = permission_level.high;
                                    }
                                    items.Add(new superEmployee(data[0], data[1], data[2], Double.Parse(data[3]), Double.Parse(data[4]), i, data[6]));
                                    break;
                            }
                        }
                     }
                }
            }

            return items;
        }

        private List<object> Json()
        {
            List<object> items = new List<object>();
            string json;
            if (File.Exists(this.File_Name))
            {
                using (StreamReader r = new StreamReader(this.File_Name))
                {
                    json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<object>>(json);
                }
            }

            return items;
        }
    
        
    }
}
