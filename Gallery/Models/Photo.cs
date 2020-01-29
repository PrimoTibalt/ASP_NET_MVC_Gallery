using System;
using System.ComponentModel;
using System.Drawing;

namespace Gallery.Models
{
    [Serializable]
    public class Photo : IDataErrorInfo
    {
        public Photo(string name, string path)
        {
            this.Picture = Image.FromFile(path);
        }

        public string this[string columnName]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(columnName))
                {
                    return "Please, enter correct value";
                }

                return null;
            }
        }

        public string Name { get; set; }

        public string Path { get; set; }

        public Image Picture { get; set; }

        public string Error { get { return null; } }
    }
}