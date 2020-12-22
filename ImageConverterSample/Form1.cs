using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageConverterSample.LanguageExtensions;
using ImageHelpers;

namespace ImageConverterSample
{
    
#nullable enable
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {

            var basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Icons");
            
            Agent1PictureBox.LoadIconFromFile(Path.Combine(basePath, "agent1.ico"));
            cSharpPictureBox.LoadIconFromFile(Path.Combine(basePath, "Csharp.ico"));
            ExcelPictureBox.LoadIconFromFile(Path.Combine(basePath, "Excel.ico"));
            SearchPictureBox.Image = Converters.FromBytesToBitMap(Path.Combine(basePath, "Search.ico"));

            var closeImage = Converters.FromBytesToBitMap(Path.Combine(basePath, "Close.ico"));
            CloseButton.Image = closeImage;
            ExitToolStripMenuItem.Image = closeImage;

        }
        
    }
}
