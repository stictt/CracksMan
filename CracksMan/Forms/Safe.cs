using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CracksMan.Infrastructure;
using CracksMan.Properties;
using Vector2 = CracksMan.Models.Vector2;

namespace CracksMan
{
    public partial class Safe : Form
    {

        private const int _limitSides = 28;
        private const int _limitUpDown = 97;
        private Size _controlsHandle;
        public Safe(Table handles)
        {
            InitializeComponent();
            _controlsHandle = GetSizeHandle(handles.CountColumns, handles.CountLines);
            BuildForm(handles);
        }

        private Size GetSizeHandle(int columns, int lines)
        {
            int width = (this.Size.Width - _limitSides*2)/ columns;
            int height = (this.Size.Height - _limitUpDown * 2) / lines;
            int minSize = new int[] { width, height }.Min();
            Size size = new Size(minSize, minSize);
            return size;
        }

        private Point GetPoint(Vector2 vector, int columns, int lines)
        {
            var width = (this.Size.Width - (_limitSides * 2)) / columns;
            var height = (this.Size.Height - (_limitUpDown * 2)) / lines;
            return new Point(_limitSides + (vector.X - 1) * width, 97 + (vector.Y - 1) * height);
        }

        private void BuildForm(Table table)
        {
            foreach(var item in table)
            {
                FillFieldsHandle(item, table);
                AddControl(item);
            }
        }

        private void FillFieldsHandle(Handle handle, Table table)
        {
            handle.BackColor = Color.Transparent;
            handle.BackgroundImage = Resources.Handle_State_UP;
            handle.BackgroundImageLayout = ImageLayout.Stretch;
            handle.Location = GetPoint(handle.Vector2 , table.CountColumns, table.CountLines);
            handle.Name = $"handle{handle.Vector2.X * handle.Vector2.Y}";
            handle.Size = _controlsHandle;
            handle.TabIndex = handle.Vector2.X * handle.Vector2.Y + 50;
        }
        private void AddControl(Handle handle)
        {
            this.Controls.Add(handle);
        }
    }
}
